using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Hotel_Service
    {
        public Hotel Hotel { get; set; }
        public int Hotel_Id { get; set; }
        public ServiceHotel Service { get; set; }
        public int Service_Id { get; set; }
        public bool Surcharge { get; set; }
    }
}
