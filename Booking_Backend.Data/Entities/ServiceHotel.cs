using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ServiceHotel
    {
        public int Id { get; set; }
        public List<Hotel_Service> Hotel_Services { get; set; }
        public List<ServiceHotelTranslation> ServiceHotelTranslations { get; set; }

    }
}
