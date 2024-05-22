using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingCartRepo.Request
{
    public class AddToCartRequest
    {
        public int HotelId { get; set; }
        public Guid UserId { get; set; }
    }
}
