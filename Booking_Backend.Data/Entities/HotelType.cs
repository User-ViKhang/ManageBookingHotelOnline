using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class HotelType
    {
        public int Id { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<HotelTypeTranslation> HotelTypeTranslations { get; set; }
        public HotelTypeImage HotelTypeImage { get; set; }
        public int HotelTypeImage_Id { get; set; }

    }
}
