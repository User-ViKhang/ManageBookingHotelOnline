using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class UserImage
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public decimal ImageSize { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Created { get; set; }
        public bool isDefault { get; set; }
        public AppUser User { get; set; }
        public Guid User_Id { get; set; }
    }
}
