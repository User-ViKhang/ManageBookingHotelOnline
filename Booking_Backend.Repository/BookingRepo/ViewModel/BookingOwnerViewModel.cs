using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.ViewModel
{
    public class BookingOwnerViewModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalRoom { get; set; }
        public int? TotalPeople { get; set; }
        public string? Note { get; set; }
        public StatusBooking Status { get; set; }
        public Room Room { get; set; }
        public Bed Bed { get; set; }
        public Booking_Backend.Data.Entities.RoomType RoomType {  get; set; }
        public GuestCustomer GuestCustomer { get; set; }
    }
}
