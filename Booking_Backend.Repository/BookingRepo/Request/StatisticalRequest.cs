using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.Request
{
    public class StatisticalRequest
    {
        public int STT { get; set; }
        public int BookingId { get; set; }
        public string RoomCode { get; set; }
        public string RoomTypeName { get; set; }
        public string BedName { get; set; }
        public int TotalPeople { get; set; }
        public int DayNumber { get; set; }
        public string UserName { get; set; }
        public int Phuthu { get; set; }
        public string Price { get; set; }
        public string TotalPrice { get; set; }
        public string Create { get; set; }
    }
}
