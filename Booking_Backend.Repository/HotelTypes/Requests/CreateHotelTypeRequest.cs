using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.Requests
{
    public class CreateHotelTypeRequest
    {
        public string NameVI { get; set; }
        public string NameEN { get; set; }
        public IFormFile Image { get; set; }
    }
}