using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BedRepo.Request
{
    public class CreateBedRequest
    {
        public string NameVI { get; set; }
        public string DescriptionVI { get; set; }
        public string DescriptionEN { get; set; }
        public string NameEN { get; set; }
    }
}
