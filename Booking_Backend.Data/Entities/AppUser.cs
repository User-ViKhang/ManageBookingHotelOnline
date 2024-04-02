using Booking_Backend.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public DateTime Birthday { get; set; }
        public string Nation { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Dashboard { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime Created { get; set; }
        public StatusUser Status { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<UserImage> UserImages { get; set; }
        public List<Hotel> Hotels { get; set; }

    }
}
