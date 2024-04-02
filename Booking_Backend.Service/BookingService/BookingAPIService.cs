using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.GuestCustomerRepo.Request;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.GuestCustomerService;
using Booking_Backend.Service.SendEmail;
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

        public BookingAPIService(BookingContext context, IGuestCustomerAPIService guestCus, IEmailService emailService)
        {
            _context = context;
            _guestCus = guestCus;
            _emailService = emailService;
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
                CheckIn = request.CheckOut,
                CheckOut = request.CheckOut,
                Created = DateTime.UtcNow,
                TotalAmount = (decimal)request.TotalRoom * request.Price,
                TotalRoom = request.TotalRoom,
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
            return true;
        }


    }
}
