using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.Requests
{
    public class CreateHotelTypeRequest
    {
        public string Name { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}