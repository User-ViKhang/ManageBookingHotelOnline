using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class TopHotelViewModel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public HotelType HotelType { get; set; }
    }
}
