using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Bed
    {
        public int Id { get; set; }

        public List<Room> Rooms { get; set; }
        public List<BedTranslation> BedTranslations { get; set; }

    }
}
