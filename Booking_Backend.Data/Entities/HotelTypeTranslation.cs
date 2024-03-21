using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class HotelTypeTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }
        public HotelType HotelType { get; set; }
        public int HotelType_Id { get; set; }

    }
}