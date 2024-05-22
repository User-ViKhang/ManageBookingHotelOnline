using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Service.Request
{
    public class UpdateServiceHotelRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
    }
}
