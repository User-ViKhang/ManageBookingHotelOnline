using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ServiceHotelTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language_Id { get; set; }
        public ServiceHotel ServiceHotel { get; set; }
        public int ServiceHotel_Id { get; set; }
    }
}
