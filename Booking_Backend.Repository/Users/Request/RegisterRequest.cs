using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Users.Request
{
    public class RegisterRequest
    {
        public string DisplayName { get; set; }
        public string Nation { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
