using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Booking_Backend.Data.Entities
{
    public class Room_Booking
    {
        [JsonIgnore]
        public Room Room { get; set; }
        public int Room_Id { get; set; }
        [JsonIgnore]
        public Booking Booking { get; set; }
        public int Booking_Id { get; set; }
    }
}
