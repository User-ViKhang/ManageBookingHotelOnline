using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Service.Request
{
    public class CreateServiceHotelRequest
    {
        public string NameVI { get; set; }
        public string NameEN { get; set; }
        public string DescriptionVI { get; set; }
        public string DescriptionEN { get; set; }
    }
}
