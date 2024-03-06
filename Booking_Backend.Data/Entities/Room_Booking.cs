using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Room_Booking
    {
        public Room Room { get; set; }
        public int Room_Id { get; set; }
        public Booking Booking { get; set; }
        public int Booking_Id { get; set; }
    }
}
