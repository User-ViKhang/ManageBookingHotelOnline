using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class RoomTypeTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }

        public RoomType RoomType { get; set; }
        public int RoomType_Id { get; set; }
    }
}
