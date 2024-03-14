using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class HotelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Language { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<HotelTypeImage> HotelTypeImages { get; set; }
    }
}