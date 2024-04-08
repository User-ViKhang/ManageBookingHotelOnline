using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Booking_Backend.Data.Entities
{
    public class HotelTypeImage
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public decimal ImageSize { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Created { get; set; }
        public bool isDefault { get; set; }

        [JsonIgnore]
        public HotelType HotelType { get; set; }
    }
}