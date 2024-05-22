using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.BookingCartRepo.Request;
using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using Booking_Backend.Service.BillService;
using Booking_Backend.Service.GuestCustomerService;
using Booking_Backend.Service.Rooms;
using Booking_Backend.Service.SendEmail;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BookingCartService
{
    public class BookingCartAPIService : IBookingCartAPIService
    {
        private readonly BookingContext _context;
        private readonly UserManager<AppUser> _userManage;

        public BookingCartAPIService(BookingContext context, UserManager<AppUser> userManage)
        {
            _context = context;
            _userManage = userManage;
        }

        public async Task<bool> AddToCart(AddToCartRequest request)
        {
            var addToCart = new BookingCarts
            {
                Created = DateTime.Now,
                Hotel_Id = request.HotelId,
                User_Id = request.UserId,
                Hotel = await _context.Hotels.FindAsync(request.HotelId),
                User = await _userManage.FindByIdAsync(request.UserId.ToString())
            };
            _context.BookingCarts.Add(addToCart);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteFromCart(AddToCartRequest request)
        {
            var bookingCart = await _context.BookingCarts.FirstOrDefaultAsync(x => x.User_Id ==  request.UserId && x.Hotel_Id == request.HotelId);
            _context.BookingCarts.Remove(bookingCart);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<ListBookingCartByUserIdModel>> GetAllBookingCartByUserId(Guid UserId)
        {
            var lstBookingCart = await _context.Users
                            .Include(u => u.BookingCarts).ThenInclude(bc => bc.Hotel).ThenInclude(h => h.HotelTranslations)
                            .Where(u => u.Id == UserId)
                            .SelectMany(u => u.BookingCarts)
                            .Select(bc => new ListBookingCartByUserIdModel
                            {
                                HotelId = bc.Hotel_Id,
                                HotelName = bc.Hotel.HotelTranslations.FirstOrDefault().Name,
                                UserId = bc.User_Id,
                                Created = bc.Created,
                                Score = bc.Hotel.Score,
                                Thumbnail = bc.Hotel.Thumbnail
                            })
                            .ToListAsync();
            return lstBookingCart;
        }
    }
}
