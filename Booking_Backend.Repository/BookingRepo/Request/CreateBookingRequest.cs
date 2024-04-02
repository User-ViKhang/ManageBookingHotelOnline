using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.Request
{
    public class CreateBookingRequest
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public string RoomTypeName { get; set; }
        public string BedName { get; set; }
        public decimal Price { get; set; }
        public int RoomQuality { get; set; }


        public string fullnameCustomer { get; set; }
        public string emailCustomer { get; set; }
        public string phoneCustomer { get; set; }
        public string noteCustomer { get; set; }
        public string nation { get; set; }

        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public int TotalPeople { get; set; }

    }
}
