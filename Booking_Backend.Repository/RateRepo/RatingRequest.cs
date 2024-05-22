using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.RateRepo
{
    public class RatingRequest
    {
        public decimal StaffScore { get; set; }
        public decimal ComfortScore { get; set; }
        public decimal FacilitiesScore { get; set; }
        public decimal CleanlinessScores { get; set; }
        public decimal ValueScore { get; set; }
        public decimal LocationScore { get; set; }
        public int HotelId { get; set; }
        public string UserId { get; set; }
    }
}
