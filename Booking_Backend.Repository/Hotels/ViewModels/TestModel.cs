using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Hotline { get; set; }
        public List<HotelTranslation> HotelTranslations { get; set; }
    }
}
