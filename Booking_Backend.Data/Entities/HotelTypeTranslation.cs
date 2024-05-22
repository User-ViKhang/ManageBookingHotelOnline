using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Booking_Backend.Data.Entities
{
    public class HotelTypeTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }
        [JsonIgnore]
        public HotelType HotelType { get; set; }
        public int HotelType_Id { get; set; }

    }
}