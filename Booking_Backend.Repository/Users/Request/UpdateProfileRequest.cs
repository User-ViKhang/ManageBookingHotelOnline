﻿using Booking_Backend.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Users.Request
{
    public class UpdateProfileRequest
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public DateTime Birthday { get; set; }
        public string Nation { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Dashboard { get; set; }
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        public IFormFile Avatar { get; set; }
    }
}
