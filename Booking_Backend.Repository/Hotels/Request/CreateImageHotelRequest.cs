using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.Request
{
    public class CreateImageHotelRequest
    {
        public IFormFile Image { get; set; }
    }
}
