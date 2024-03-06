using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Users.Request
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RemmemberMe { get; set; }
    }
}
