using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.UserImage.Request
{
    public class CreateUserImageRequest
    {
        public string Caption { get; set; }
        public bool isDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
