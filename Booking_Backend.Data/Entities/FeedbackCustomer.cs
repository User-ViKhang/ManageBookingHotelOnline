using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class FeedbackCustomer
    {
        public int Id { get; set; } 
        public AppUser User { get; set; } 
        public Guid UserId { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }

        public decimal StaffScore { get; set; }
        public decimal ComfortScore { get; set; }
        public decimal FacilitiesScore { get; set; }
        public decimal CleanlinessScore { get; set; }
        public decimal LocationScore { get; set; }
        public decimal ValueScore { get; set; }
        public decimal Score { get; set; }
    }
}
