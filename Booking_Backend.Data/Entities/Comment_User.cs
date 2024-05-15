using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Booking_Backend.Data.Entities
{
    public class Comment_User
    {
        //[JsonIgnore]
        public Comment Comment { get; set; }
        public int Comment_Id { get; set; }
        //[JsonIgnore]
        public AppUser User { get; set; }
        public Guid User_Id { get; set; }
    }
}
