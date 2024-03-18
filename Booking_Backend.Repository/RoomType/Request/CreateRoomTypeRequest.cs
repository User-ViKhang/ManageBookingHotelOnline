using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.RoomType.Request
{
    public class CreateRoomTypeRequest
    {
        public string Name { get; set; }
        public string LanguageId { get; set; }
    }
}
