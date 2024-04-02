using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.ViewModel
{
    public class IdenSearchViewModel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Hoteline { get; set; }
        public string RoomTypeName { get; set; }
        public string BedName { get; set; }
        public int Room_Id { get; set; }
        public decimal Price { get; set; }
        public int RoomQuality { get; set; }
        public decimal TotalRoom {  get; set; }
    }
}
