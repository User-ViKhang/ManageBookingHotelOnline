using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.Bill;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.GuestCustomerRepo.Request;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.BillService;
using Booking_Backend.Service.GuestCustomerService;
using Booking_Backend.Service.Rooms;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Service.Users;
using Booking_Backend.Utilities.Exceptions;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Errors.Model;
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
        private readonly IBillAPIService _bill;
        private readonly UserManager<AppUser> _userManager;

        public BookingAPIService(BookingContext context, IGuestCustomerAPIService guestCus, IEmailService emailService, IRoomAPIService room, IBillAPIService bill, UserManager<AppUser> userManager)
        {
            _context = context;
            _guestCus = guestCus;
            _emailService = emailService;
            _room = room;
            _bill = bill;
            _userManager = userManager;
        }

        public async Task<BillClientViewModel> BillClient(int bookingId, string languageId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking == null) return null;
            var joinBooking = await _context.Bookings
                            .Include(b => b.GuestCustomer)
                            .Include(b => b.User)
                            .Include(b => b.Room_Bookings).ThenInclude(rb => rb.Room).ThenInclude(r => r.RoomType).ThenInclude(rt => rt.RoomTypeTranslations)
                            .Include(b => b.Room_Bookings).ThenInclude(rb => rb.Room).ThenInclude(r => r.Bed).ThenInclude(rt => rt.BedTranslations)
                            .FirstOrDefaultAsync(b => b.Id == bookingId);
            var billClient = new BillClientViewModel
            {
                CreatedBooking = booking.Created,
                Checkin = booking.CheckIn,
                Checkout = booking.CheckOut,
                TotalBill = booking.TotalAmount,
                BookingId = bookingId
            };
            if (joinBooking.GuestCustomer != null)
            {
                billClient.Name = joinBooking.GuestCustomer.FullName;
                billClient.Address = "(Guest) - khách hàng duyệt web";
                billClient.Email = joinBooking.GuestCustomer.Email;
                billClient.PhoneNumber = joinBooking.GuestCustomer.PhoneNumber;
            }
            else
            {
                billClient.Name = joinBooking.User.UserName;
                billClient.Address = joinBooking.User.Address;
                billClient.Email = joinBooking.User.Email;
                billClient.PhoneNumber = joinBooking.User.PhoneNumber;
            }

            billClient.RoomBills = joinBooking.Room_Bookings.Where(x => x.Room_Id == booking.Room_Bookings.FirstOrDefault().Room_Id).Select(x => new RoomBill
            {
                RoomId = x.Room_Id,
                RoomCode = x.Room.RoomCode,
                RoomTypeName = x.Room.RoomType.RoomTypeTranslations.FirstOrDefault(x => x.Language_Id == languageId).Name,
                BedName = x.Room.Bed.BedTranslations.FirstOrDefault(x => x.Language_Id == languageId).Name,
                Price = x.Room.PriceOverNight
            }).ToList();
            return billClient;
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

        public async Task<bool> CheckoutBooking(CheckoutRequest request)
        {
            var changeStateBooking = await this.ChangeStatusBooking(request.BookingId, StatusBooking.Checked); //Thay đổi trạng thái phiếu đặt phòng sang Checked (trả phòng)
            var changeStateRoom = await _room.ChangeStatusRoom(request.RoomId, StatusRoom.Empty); //Thay đổi trạng thái phòng sang trống
            var create = await _bill.CreateBill(request.BookingId);

            var query = _context.Bookings
                        .Include(b => b.GuestCustomer)
                        .Include(b => b.User)
                        .FirstOrDefault(b => b.Id == request.BookingId);
            MailData mailContent;
            if (query.GuestCustomer != null)
            {
                mailContent = new MailData
                {
                    ReceiverEmail = query.GuestCustomer.Email,
                    ReceiverName = query.GuestCustomer.FullName,
                    Title = "Gonow.net - Xác nhận trả phòng",
                    Body = $"Xin chào {query.GuestCustomer.FullName},\n\n" +
                           $"<br/>Yêu cầu trả phòng của quý khách đã xác nhận thành công!\n" +
                           $"<br/>Cảm ơn quý khách đã tin tưởng và sử dụng dịch vu của chúng tôi\n" +
                           $"<br/> Trân trọng,\nGonow.net"
                };
            }
            else
            {
                mailContent = new MailData
                {
                    ReceiverEmail = query.User.Email,
                    ReceiverName = query.User.DisplayName,
                    Title = "Gonow.net - Xác nhận trả phòng",
                    Body = $"Xin chào {query.User.DisplayName},\n\n" +
                           $"<br/>Yêu cầu trả phòng của quý khách đã xác nhận thành công!\n" +
                           $"<br/>Cảm ơn quý khách đã tin tưởng và sử dụng dịch vu của chúng tôi\n" +
                           $"<br/> Trân trọng,\nGonow.net"
                };
            }
            var sendmail = await _emailService.SendEmailAsync(mailContent);
            return true;
        }

        public async Task<bool> ConfirmBooking(int Id, ConfirmBookingRequest request)
        {
            var changeState = await this.ChangeStatusBooking(Id, request.Status);
            var changeStatusRoom = await _room.ChangeStatusRoom(request.RoomId, StatusRoom.Full);
            if (request.Status == StatusBooking.Success)
            {
                var mailContent = new MailData
                {
                    ReceiverEmail = request.Email,
                    ReceiverName = request.FullName,
                    Title = "Gonow.net - Xác nhận đặt phòng",
                    Body =
                       $"<br/>Xin chào {request.FullName},\n\n" +
                       $"<br/>Chúc mừng! Đặt phòng của bạn tại chỗ nghỉ đã được xác nhận thành công.\n" +
                       $"<br/><strong>Thông tin đặt phòng:</strong>\n" +
                       $"<br/> - Loại phòng: {request.RoomTypeName}\n" +
                       $"<br/> - Loại giường: {request.BedName}\n" +
                       $"<br/> - Số lượng người đi: {request.TotalPeople}\n" +
                       $"<br/> - Thời gian check-in: {request.Checkin.ToString("dd/MM/yyyy")}\n" +
                       $"<br/> - Thời gian check-out: {request.Checkout.ToString("dd/MM/yyyy")}\n" +
                       $"<br/> - Tổng tiền: {request.TotalAmount.ToString("N0")}\n" +
                       $"<br/> Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.\n\n" +
                       $"<br/> Trân trọng,\nGonow.net"
                };
                var sendmail = await _emailService.SendEmailAsync(mailContent);
            }
            return true;
        }

        public async Task<bool> CreateBooking(BookingRequest request, Payment payment)
        {
            if (request.UserId == null)
            {
                var guestCustomerRequest = new CreateGuestCustomerRequest()
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    Nation = request.Nation,
                    PhoneNumber = request.PhoneNumber
                };
                var guestCus = await _guestCus.CreateGuestCustomer(guestCustomerRequest);

                var guest = await _context.GuestCustomers.FirstOrDefaultAsync(x => x.Id == guestCus.ResultOject.Id);

                var hotel = await _context.Hotels
                           .Include(x => x.User)
                           .Include(x => x.HotelTranslations)
                           .FirstOrDefaultAsync(x => x.Id == request.HotelId);

                var resultRoom = await _context.Rooms.FindAsync(request.RoomId);
                resultRoom.Status = StatusRoom.Full;
                _context.Rooms.Update(resultRoom);
                var createBooking = new Booking()
                {
                    CheckIn = request.CheckIn,
                    CheckOut = request.CheckOut,
                    Created = DateTime.UtcNow,
                    TotalAmount = request.Sum,
                    TotalRoom = request.TotalRoom,
                    TotalPeople = request.TotalPeople,
                    Note = request.Note,
                    GuestCustomer = guest,
                    Status = StatusBooking.Pedding,
                    Payment = payment
                };
                _context.Bookings.Add(createBooking);

                var addBooking = new Room_Booking
                {
                    Room = resultRoom,
                    Room_Id = resultRoom.Id,
                    Booking_Id = createBooking.Id,
                    Booking = createBooking
                };
                _context.Room_Bookings.Add(addBooking);
                await _context.SaveChangesAsync();

                var sendMailRequest = new MailData()
                {
                    ReceiverName = hotel.HotelTranslations.Where(x => x.Language_Id == request.LanguageId).Select(x => x.Name).FirstOrDefault(),
                    ReceiverEmail = hotel.User.Email,
                    Body = $"{hotel.HotelTranslations.Where(x => x.Language_Id == request.LanguageId).Select(x => x.Name).FirstOrDefault()} có một yêu cầu đặt phòng mới!",
                    Title = "Gonow.net - Booknow"
                };
                var sendMail = await _emailService.SendEmailAsync(sendMailRequest);
                return true;
            }
            else
            {
                var hotel = await _context.Hotels
                           .Include(x => x.User)
                           .Include(x => x.HotelTranslations)
                           .FirstOrDefaultAsync(x => x.Id == request.HotelId);

                var resultRoom = await _context.Rooms.FindAsync(request.RoomId);
                resultRoom.Status = StatusRoom.Full;
                _context.Rooms.Update(resultRoom);
                var user = await _userManager.FindByIdAsync(request.UserId);
                if (user == null) return false;
                var createBooking = new Booking()
                {
                    CheckIn = request.CheckIn,
                    CheckOut = request.CheckOut,
                    Created = DateTime.UtcNow,
                    TotalAmount = request.Sum,
                    TotalRoom = request.TotalRoom,
                    TotalPeople = request.TotalPeople,
                    Note = request.Note,
                    User = user,
                    User_Id = Guid.Parse(request.UserId),
                    Status = StatusBooking.Pedding,
                    Payment = payment
                };
                _context.Bookings.Add(createBooking);

                var addBooking = new Room_Booking
                {
                    Room = resultRoom,
                    Room_Id = resultRoom.Id,
                    Booking_Id = createBooking.Id,
                    Booking = createBooking
                };
                _context.Room_Bookings.Add(addBooking);
                await _context.SaveChangesAsync();

                var sendMailRequest = new MailData()
                {
                    ReceiverName = hotel.HotelTranslations.Where(x => x.Language_Id == request.LanguageId).Select(x => x.Name).FirstOrDefault(),
                    ReceiverEmail = hotel.User.Email,
                    Body = $"{hotel.HotelTranslations.Where(x => x.Language_Id == request.LanguageId).Select(x => x.Name).FirstOrDefault()} có một yêu cầu đặt phòng mới!",
                    Title = "Gonow.net - Booknow"
                };
                var sendMail = await _emailService.SendEmailAsync(sendMailRequest);
                return true;
            }
        }

        public async Task<bool> DeleteBooking(int roomId, int bookingId)
        {
            var booking = await _context.Room_Bookings.Where(br => br.Room_Id == roomId && br.Booking_Id == bookingId).FirstOrDefaultAsync();
            if (booking == null) return false;
            _context.Room_Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<BookingOwnerViewModel>> GetAllBookingOwner(int hotelId, string languageId, StatusBooking? status)
        {
            var bookings = await _context.Room_Bookings
                .Include(rb => rb.Booking).ThenInclude(b => b.GuestCustomer)
                .Include(rb => rb.Booking).ThenInclude(b => b.User)
                .Include(rb => rb.Room).ThenInclude(r => r.RoomType)
                .Include(rb => rb.Room).ThenInclude(r => r.Bed)
                .Where(rb => rb.Room.Hotel_Id == hotelId && rb.Booking.Status == status)
                .Select(rb => new BookingOwnerViewModel
                {
                    Id = rb.Booking_Id,
                    Created = rb.Booking.Created,
                    CheckIn = rb.Booking.CheckIn,
                    CheckOut = rb.Booking.CheckOut,
                    TotalAmount = rb.Booking.TotalAmount,
                    TotalPrice = rb.Room.PriceOverNight,
                    TotalPeople = rb.Booking.TotalPeople,
                    TotalRoom = rb.Booking.TotalRoom,
                    Note = rb.Booking.Note,
                    Status = rb.Booking.Status,
                    Room = new Room
                    {
                        Id = rb.Room_Id,
                        RoomCode = rb.Room.RoomCode,
                        Maximum = rb.Room.Maximum,
                        Status = rb.Room.Status,
                        PriceByHour = rb.Room.PriceByHour,
                        PriceOverNight = rb.Room.PriceOverNight
                    },
                    RoomType = new RoomType
                    {
                        Id = rb.Room.RoomType_Id,
                        RoomTypeTranslations = rb.Room.RoomType.RoomTypeTranslations
                            .Where(rt => rt.Language_Id == languageId)
                            .Select(rt => new RoomTypeTranslation
                            {
                                Id = rt.Id,
                                Name = rt.Name,
                                Language_Id = languageId,
                                RoomType_Id = rb.Room.RoomType_Id
                            }).ToList()
                    },
                    GuestCustomer = rb.Booking.GuestCustomer,
                    User = rb.Booking.User,
                    Bed = new Bed
                    {
                        Id = rb.Room.Bed_Id,
                        BedTranslations = rb.Room.Bed.BedTranslations
                            .Where(bt => bt.Language_Id == languageId)
                            .Select(bt => new BedTranslation
                            {
                                Id = bt.Id,
                                Name = bt.Name,
                                Language_Id = languageId,
                                Bed_Id = rb.Room.Bed_Id
                            }).ToList()
                    }
                }).ToListAsync();
            return bookings;
        }

        public async Task<BookingOwnerViewModel> GetBookingOwnerById(int bookingId, string LanguageId)
        {
            var booking = await _context.Bookings
                .Include(b => b.GuestCustomer)
                .Include(b => b.User)
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
                User = booking.User,
                Note = booking.Note,
                TotalPeople = booking.TotalPeople,
                Payment = booking.Payment,
                TotalPrice = booking.Room_Bookings.FirstOrDefault().Room.PriceOverNight,
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

        [HttpGet("{LanguageId}/{userId}")]
        public async Task<List<BookingHistoriesViewModel>> GetBookingOwnerByUserId(string userId, string LanguageId)
        {
            var bookings = await _context.Bookings
               .Where(b => b.User_Id == Guid.Parse(userId))
               .Select(b => new
               {
                   CheckIn = b.CheckIn,
                   CheckOut = b.CheckOut,
                   Payment = b.Payment,
                   TotalAmount = b.TotalAmount,
                   Status = b.Status,
                   Room = b.Room_Bookings.Select(rb => new
                   {
                       RoomCode = rb.Room.RoomCode,
                       HotelName = rb.Room.Hotel.HotelTranslations.FirstOrDefault(x => x.Language_Id == LanguageId).Name,
                       RoomTypeName = rb.Room.RoomType.RoomTypeTranslations.FirstOrDefault(x => x.Language_Id == LanguageId).Name,
                       BedName = rb.Room.Bed.BedTranslations.FirstOrDefault(x => x.Language_Id == LanguageId).Name
                   }).FirstOrDefault()
               })
               .ToListAsync();

            var viewModelList = bookings.Select(b => new BookingHistoriesViewModel
            {
                HotelName = b.Room.HotelName,
                RoomCode = b.Room.RoomCode,
                RoomTypeName = b.Room.RoomTypeName,
                BedName = b.Room.BedName,
                StayDay = (int)b.CheckOut.Day - (int)b.CheckIn.Day,
                Payment = b.Payment,
                Total = b.TotalAmount,
                Status = b.Status,
                CheckIn = b.CheckIn,
                CheckOut = b.CheckOut
            }).ToList();

            return viewModelList;
        }
    }
}
