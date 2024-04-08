using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class HotelViewViewModel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string ImageHotel { get; set; }
        public int StartPrice { get; set; }
        public string Address { get; set; }
    }
}
