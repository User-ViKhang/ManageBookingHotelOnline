using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.ViewModel
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalRoom { get; set; }
        public string? Note { get; set; }
        public Guid? User_Id { get; set; }
        public int? GuestCustomer_Id { get; set; }
        public StatusBooking Status { get; set; }
    }
}
