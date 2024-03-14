using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.Requests
{
    public class UpdateHotelTypeRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string LanguageId { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}