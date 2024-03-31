using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public int Properties { get; set; }
        public List<LocationTranslation> LocationTranslations { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
