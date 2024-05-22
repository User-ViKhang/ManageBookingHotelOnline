using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.CommentRepo.Request
{
    public class LikeCommentRequest
    {
        public int HotelId { get; set; }
        public int CommentId { get; set; }
        public Guid UserId { get; set; }
    }
}
