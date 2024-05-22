using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ViewHotel
    {
        public int Id { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<ViewHotelTranslation> ViewHotelTranslations { get; set; }
    }
}
