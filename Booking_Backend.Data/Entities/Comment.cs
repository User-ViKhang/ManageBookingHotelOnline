using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int CountComment { get; set; }
        public Hotel Hotel { get; set; }
        public int Hotel_Id { get; set; }
        public AppUser User { get; set; }
        public Guid User_Id { get; set; }
        public List<Comment_User> Comment_Users { get; set; }
    }
}
