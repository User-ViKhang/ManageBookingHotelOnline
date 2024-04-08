using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.Request
{
    public class ConfirmBookingRequest
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string RoomTypeName { get; set; }
        public string BedName { get; set; }
        public int TotalPeople { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public decimal TotalAmount { get; set; }
        public StatusBooking Status { get; set; }
        public int RoomId { get; set; }
    }
}
