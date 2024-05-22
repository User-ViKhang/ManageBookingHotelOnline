using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.CommentRepo.Request
{
    public class CreateCommentRequest
    {
        public int HotelId { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
    }
}
