using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Booking_Backend.Data.Entities
{
    public class HotelType
    {
        public int Id { get; set; }
        [JsonIgnore]
        public List<Hotel> Hotels { get; set; }
        [JsonIgnore]
        public List<HotelTypeTranslation> HotelTypeTranslations { get; set; }
        [JsonIgnore]
        public HotelTypeImage HotelTypeImage { get; set; }
        public int HotelTypeImage_Id { get; set; }
    }
}
