using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BedRepo.Request
{
    public class UpdateBedRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language_Id { get; set; }
    }
}
