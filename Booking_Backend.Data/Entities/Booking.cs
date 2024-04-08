using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Booking_Backend.Data.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalRoom { get; set; }
        public string? Note { get; set; }
        public int? TotalPeople { get; set; }
        public AppUser? User { get; set; }
        public Guid? User_Id { get; set; }
        [JsonIgnore]
        public GuestCustomer GuestCustomer { get; set; }
        public int? GuestCustomer_Id { get; set; }
        public StatusBooking Status { get; set; }
        public List<Room_Booking> Room_Bookings { get; set; }

    }
}
