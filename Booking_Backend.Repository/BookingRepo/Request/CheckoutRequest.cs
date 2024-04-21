using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.Request
{
    public class CheckoutRequest
    {
        public int RoomId { get; set; }
        public int BookingId { get; set; }
    }
}
