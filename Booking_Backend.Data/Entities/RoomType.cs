using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class RoomType
    {
        public int Id { get; set; }
        public List<Room> Rooms { get; set; }
        public List<RoomTypeTranslation> RoomTypeTranslations { get; set; }
    }
}
