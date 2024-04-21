using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.CommentRepo.ViewModel
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int HotelId { get; set; }
        public AppUser User { get; set; }
    }
}
