using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public DateTime Establish { get; set; }
        public int HotelType_Id { get; set; }
        public string Language { get; set; }
    }
}
