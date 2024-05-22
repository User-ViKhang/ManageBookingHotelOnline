using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BillService
{
    public class BillAPIService : IBillAPIService
    {
        private readonly BookingContext _context;

        public BillAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBill(int bookingId)
        {
            var booking_rooms = await _context.Room_Bookings.Where(x=>x.Booking_Id == bookingId).ToListAsync();
            if (booking_rooms == null) return false;

            var query = _context.Room_Bookings
               .Include(br => br.Booking).ThenInclude(b => b.User)
               .Include(br => br.Booking).ThenInclude(b => b.GuestCustomer)
               .Include(br => br.Room).ThenInclude(r => r.Hotel)
               .Include(br => br.Room).ThenInclude(r => r.RoomType)
               .Include(br => br.Room).ThenInclude(r => r.Bed)
               .Where(x => x.Booking_Id == bookingId);
            booking_rooms.FirstOrDefault().Booking = query.FirstOrDefault(x=>x.Booking_Id == bookingId).Booking;
            booking_rooms.FirstOrDefault().Room = query.FirstOrDefault().Room;
            var create = new Bill
            {
                Room_Bookings = booking_rooms,
                Created_at = DateTime.Now,
                GuestCustomer = booking_rooms.FirstOrDefault().Booking.GuestCustomer,
                GuestCustomer_Id = booking_rooms.FirstOrDefault().Booking.GuestCustomer_Id,
                User = booking_rooms.FirstOrDefault().Booking.User,
                User_Id = booking_rooms.FirstOrDefault().Booking.User_Id
            };
            await _context.AddAsync(create);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
