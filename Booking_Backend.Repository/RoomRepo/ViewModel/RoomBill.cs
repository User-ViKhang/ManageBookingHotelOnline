using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.RoomRepo.ViewModel
{
    public class RoomBill
    {
        public int RoomId { get; set; }
        public int BookingId { get; set; }
        public string RoomCode { get; set; }
        public string RoomTypeName { get; set; }
        public string BedName { get; set; }
        public decimal Price { get; set; }
    }
}
