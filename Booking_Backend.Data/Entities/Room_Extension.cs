using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Room_Extension
    {
        public int Quantity { get; set; }
        public Room Room { get; set; }
        public int Room_Id { get; set; }
        public Extension Extension { get; set; }
        public int Extension_Id { get; set; }
    }
}
