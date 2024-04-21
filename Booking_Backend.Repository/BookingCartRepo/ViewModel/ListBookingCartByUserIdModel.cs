using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingCartRepo.ViewModel
{
    public class ListBookingCartByUserIdModel
    {
        public Guid UserId { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Thumbnail { get; set; }
        public decimal? Score { get; set; }
        public DateTime Created { get; set; }
    }
}
