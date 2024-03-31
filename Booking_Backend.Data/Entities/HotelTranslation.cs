using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Booking_Backend.Data.Entities
{
    public class HotelTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string? ShortDescription { get; set; }
        public string Language_Id { get; set; }

        public Hotel Hotel { get; set; }
        public int Hotel_Id { get; set; }

    }
}
