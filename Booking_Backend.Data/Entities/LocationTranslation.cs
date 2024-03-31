using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class LocationTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }
        public Location Location { get; set; }
        public int Location_Id { get; set; }
    }
}
