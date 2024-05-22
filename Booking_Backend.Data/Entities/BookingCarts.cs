using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class BookingCarts
    {
        public Hotel Hotel { get; set; }
        public int Hotel_Id { get; set; }
        public AppUser User { get; set; }
        public Guid User_Id { get; set; }
        public DateTime Created { get; set; }
    }
}
