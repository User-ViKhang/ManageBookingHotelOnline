using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.ViewModel
{
    public class BookingHistoriesViewModel
    {
        public string HotelName { get; set; }
        public string RoomCode { get; set; }
        public string BedName { get; set; }
        public string RoomTypeName { get; set; }
        public int StayDay { get; set; }
        public decimal Total { get; set; }
        public Payment Payment { get; set; }
        public StatusBooking Status { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
