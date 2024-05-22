using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class BedTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language_Id { get; set; }

        public Bed Bed { get; set; }
        public int Bed_Id { get; set; }
    }
}
