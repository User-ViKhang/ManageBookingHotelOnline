using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class GuestCustomer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nation { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
