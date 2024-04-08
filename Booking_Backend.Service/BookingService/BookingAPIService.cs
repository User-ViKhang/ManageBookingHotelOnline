using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.GuestCustomerRepo.Request;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.GuestCustomerService;
using Booking_Backend.Service.Rooms;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BookingService
{
    public class BookingAPIService : IBookingAPIService
    {
        private readonly BookingContext _context;
        private readonly IGuestCustomerAPIService _guestCus;
        private readonly IEmailService _emailService;
        private readonly IRoomAPIService _room;

        public BookingAPIService(BookingContext context, IGuestCustomerAPIService guestCus, IEmailService emailService, IRoomAPIService room)
        {
            _context = context;
            _guestCus = guestCus;
            _emailService = emailService;
            _room = room;
        }

        public async Task<bool> ChangeStatusBooking(int Id, StatusBooking state)
        {
            var booking = await _context.Bookings.FindAsync(Id);
            if (booking == null) throw new BookingException("Phiếu đăng kí không tồn tại");
            booking.Status = state;
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ConfirmBooking(int Id, ConfirmBookingRequest request)
        {
            var changeState = await this.ChangeStatusBooking(Id, request.Status);
            var changeStatusRoom = await _room.ChangeStatusRoom(request.RoomId, StatusRoom.Full);
            if(request.Status == StatusBooking.Success)
            {
                var mailContent = new MailData
                {
                    ReceiverEmail = request.Email,
                    ReceiverName = request.FullName,
                    Title = "Gonow.net - Xác nhận đặt phòng",
                    Body = $"Xin chào {request.FullName},\n\n" +
                       $"Chúc mừng! Đặt phòng của bạn tại chỗ nghỉ đã được xác nhận thành công.\n" +
                       $"Thông tin đặt phòng:\n" +
                       $"- Loại phòng: {request.RoomTypeName}\n" +
                       $"- Loại giường: {request.BedName}\n" +
                       $"- Số lượng người đi: {request.TotalPeople}\n" +
                       $"- Thời gian check-in: {request.Checkin}\n" +
                       $"- Thời gian check-out: {request.Checkout}\n" +
                       $"- Tổng tiền: {request.TotalAmount}\n" +
                       $"Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.\n\n" +
                       $"Trân trọng,\nGonow.net"
                };
                var sendmail = await _emailService.SendEmailAsync(mailContent);
            }
            return true;
        }

        public async Task<bool> CreateBooking(BookingRequest request)
        {
            var emptyGuest = await _context.GuestCustomers.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (emptyGuest == null)
            {
                var guestCustomerRequest = new CreateGuestCustomerRequest()
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    Nation = request.Nation,
                    PhoneNumber = request.PhoneNumber
                };
                var guestCus = await _guestCus.CreateGuestCustomer(guestCustomerRequest);
            }

            var guest = await _context.GuestCustomers.FirstOrDefaultAsync(x => x.Email == request.Email);

            var hotel = await _context.Hotels
                        .Include(x => x.User)
                        .Include(x => x.HotelTranslations)
                        .FirstOrDefaultAsync(x => x.Id == request.HotelId);

            var sendMailRequest = new MailData()
            {
                ReceiverName = hotel.HotelTranslations.Where(x => x.Language_Id == request.LanguageId).Select(x => x.Name).FirstOrDefault(),
                ReceiverEmail = hotel.User.Email,
                Body = $"{hotel.HotelTranslations.Where(x => x.Language_Id == request.LanguageId).Select(x => x.Name).FirstOrDefault()} có một yêu cầu đặt phòng mới!",
                Title = "Gonow.net - Booknow"
            };
            var sendMail = await _emailService.SendEmailAsync(sendMailRequest);
            var createBooking = new Booking()
            {
                CheckIn = request.CheckIn,
                CheckOut = request.CheckOut,
                Created = DateTime.UtcNow,
                TotalAmount = (decimal)request.TotalRoom * request.Price,
                TotalRoom = request.TotalRoom,
                TotalPeople = request.TotalPeople,
                Note = request.Note,
                GuestCustomer = new GuestCustomer
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Nation = request.Nation
                },
                Status = StatusBooking.Pedding,
            };
            var resultRoom = await _context.Rooms.FindAsync(request.RoomId);
            _context.Bookings.Add(createBooking);
            await _context.SaveChangesAsync();

            var createBooking_Room = await _context.Bookings.FindAsync(createBooking.Id);

            var addBooking = new Room_Booking
            {
                Room = resultRoom,
                Room_Id = resultRoom.Id,
                Booking_Id = createBooking.Id,
                Booking = createBooking
            };
            _context.Room_Bookings.Add(addBooking);
            await _context.SaveChangesAsync();

            createBooking_Room.Room_Bookings = new List<Room_Booking>
            {
                new Room_Booking
                {
                    Room = resultRoom,
                    Room_Id = resultRoom.Id,
                    Booking_Id = createBooking.Id,
                    Booking = createBooking
                }
            };
            _context.Bookings.Add(createBooking_Room);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<BookingOwnerViewModel>> GetAllBookingOwner(int hoteId, string LanguageId)
        {
            var hotel = await _context.Hotels
                .Include(h => h.Rooms).ThenInclude(r => r.Room_Bookings).ThenInclude(rb => rb.Booking)
                .Include(h => h.Rooms).ThenInclude(r => r.RoomType).ThenInclude(rt => rt.RoomTypeTranslations)
                .Include(h => h.Rooms).ThenInclude(r => r.Room_Bookings).ThenInclude(rb => rb.Booking).ThenInclude(b => b.GuestCustomer)
                .FirstOrDefaultAsync(h => h.Id == hoteId);

            if (hotel == null)
            {
                return null;
            }
            var bookings = hotel.Rooms.SelectMany(r => r.Room_Bookings)
                .Select(rb => new BookingOwnerViewModel
                {
                    Id = rb.Booking.Id,
                    Created = rb.Booking.Created,
                    CheckIn = rb.Booking.CheckIn,
                    CheckOut = rb.Booking.CheckOut,
                    TotalAmount = rb.Booking.TotalAmount,
                    TotalRoom = rb.Booking.TotalRoom,
                    Note = rb.Booking.Note,
                    Status = rb.Booking.Status,
                    /*Room = new Room
                    {
                        RoomCode = rb.Room.RoomCode,
                        Maximum = rb.Room.Maximum,
                        Status = rb.Room.Status,
                        PriceByHour = rb.Room.PriceByHour,
                        PriceOverNight = rb.Room.PriceOverNight
                    }*/
                    RoomType = new RoomType
                    {
                        Id = rb.Room.RoomType.Id,
                        RoomTypeTranslations = rb.Room.RoomType.RoomTypeTranslations
                            .Where(rt => rt.Language_Id == LanguageId)
                            .Select(rt => new RoomTypeTranslation
                            {
                                Id = rt.Id,
                                Name = rt.Name,
                                Language_Id = LanguageId,
                                RoomType_Id = rb.Room.RoomType_Id
                            })
                            .ToList()
                    },
                    GuestCustomer = new GuestCustomer
                    {
                        Id = rb.Booking.GuestCustomer.Id,
                        FullName = rb.Booking.GuestCustomer.FullName,
                        PhoneNumber = rb.Booking.GuestCustomer.PhoneNumber,
                        Email = rb.Booking.GuestCustomer.Email,
                        Nation = rb.Booking.GuestCustomer.Nation,
                    }
                }).ToList();
            return bookings;
        }

        public async Task<BookingOwnerViewModel> GetBookingOwnerById(int bookingId, string LanguageId)
        {
            var booking = await _context.Bookings
                .Include(b => b.GuestCustomer)
                .Include(b => b.Room_Bookings).ThenInclude(rb => rb.Room).ThenInclude(r => r.Bed).ThenInclude(b => b.BedTranslations)
                .Include(b => b.Room_Bookings).ThenInclude(rb => rb.Room).ThenInclude(r => r.RoomType).ThenInclude(rt => rt.RoomTypeTranslations)
                .FirstOrDefaultAsync(b => b.Id == bookingId);
            if (booking == null) return null;
            var bookingVM = new BookingOwnerViewModel
            {
                Id = booking.Id,
                CheckIn = booking.CheckIn,
                CheckOut = booking.CheckOut,
                Created = booking.Created,
                GuestCustomer = booking.GuestCustomer,
                Note = booking.Note,
                TotalPeople = booking.TotalPeople,
                RoomType = new RoomType
                {
                    Id = booking.Room_Bookings.FirstOrDefault().Room.RoomType.Id,
                    RoomTypeTranslations = booking.Room_Bookings.FirstOrDefault().Room.RoomType.RoomTypeTranslations
                            .Where(rt => rt.Language_Id == LanguageId)
                            .Select(rt => new RoomTypeTranslation
                            {
                                Id = rt.Id,
                                Name = rt.Name,
                                Language_Id = LanguageId,
                                RoomType_Id = booking.Room_Bookings.FirstOrDefault().Room.RoomType_Id
                            })
                            .ToList()
                },
                Bed = new Bed
                {
                    Id = booking.Room_Bookings.FirstOrDefault().Room.Bed_Id,
                    BedTranslations = booking.Room_Bookings.FirstOrDefault().Room.Bed.BedTranslations
                    .Select(bt => new BedTranslation
                    {
                        Id = bt.Id,
                        Name = bt.Name,
                        Language_Id = LanguageId,
                    }).ToList()
                },
                Room = new Room
                {
                    Id = booking.Room_Bookings.FirstOrDefault().Room_Id,
                    RoomCode = booking.Room_Bookings.FirstOrDefault().Room.RoomCode
                },
                Status = booking.Status,
                TotalAmount = booking.TotalAmount,
                TotalRoom = booking.TotalRoom
            };
            return bookingVM;
        }
    }
}
