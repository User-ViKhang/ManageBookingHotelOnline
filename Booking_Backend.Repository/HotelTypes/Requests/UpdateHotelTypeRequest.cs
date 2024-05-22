using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.Requests
{
    public class UpdateHotelTypeRequest
    {
        public string Name { get; set; }
        public string Language_Id { get; set; }
        public IFormFile Image { get; set; }
    }
}