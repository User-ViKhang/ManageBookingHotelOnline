using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BookingRepo.Request
{
    public class BookingRequest
    {
        public DateTime Created { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalRoom { get; set; }
        public string? Note { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nation { get; set; }
        public string Thumbnail { get; set; }
        public StatusBooking Status { get; set; }
        public decimal Price { get; set; }
        public int TotalPeople { get; set; }

        public AppUser? User { get; set; }
        public string? UserId { get; set; }

        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string LanguageId { get; set; }
        public decimal Sum { get; set; }
    }
}
