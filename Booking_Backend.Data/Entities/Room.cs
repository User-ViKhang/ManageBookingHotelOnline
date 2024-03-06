using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Booking_Backend.Data.Entities
{
        public class Room
        {
            public int Id { get; set; }
            public string RoomCode { get; set; }
            public string Description { get; set; }
            public int Maximum { get; set; }
            public StatusRoom Status { get; set; }
            public decimal PriceByHour { get; set; }
            public decimal PriceOverNight { get; set; }
            public List<Room_Extension> Room_Extensions { get; set; }
            public List<Room_Booking> Room_Bookings { get; set; }
            public Hotel Hotel { get; set; }
            public int Hotel_Id { get; set; }
            public RoomType RoomType { get; set; }
            public int RoomType_Id { get; set; }
            public Bed Bed { get; set; }
            public int Bed_Id { get; set; }
            public string Language { get; set; }
        }
}
