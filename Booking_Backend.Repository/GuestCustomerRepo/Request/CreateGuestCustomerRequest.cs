using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.GuestCustomerRepo.Request
{
    public class CreateGuestCustomerRequest
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nation { get; set; }
    }
}
