using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public List<Room_Booking> Room_Bookings { get; set; }
        public AppUser? User { get; set; }
        public Guid? User_Id { get; set; }
        public GuestCustomer? GuestCustomer { get; set; }
        public int? GuestCustomer_Id { get; set; }
        public DateTime Created_at { get; set; }
    }
}
