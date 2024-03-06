using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Language
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
    }
}
