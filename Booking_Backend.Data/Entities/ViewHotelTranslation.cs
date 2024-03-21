using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ViewHotelTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language_Id { get; set; }
        public ViewHotel ViewHotel { get; set; }
        public int ViewHotel_Id { get; set; }
    }
}
