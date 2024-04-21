using Booking_Backend.Repository.RoomRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Bill
{
    public class BillClientViewModel
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public DateTime CreatedBooking { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public string Phuthu { get; set; }
        public decimal TotalBill { get; set; }

        public List<RoomBill> RoomBills { get; set; }
    }
}
