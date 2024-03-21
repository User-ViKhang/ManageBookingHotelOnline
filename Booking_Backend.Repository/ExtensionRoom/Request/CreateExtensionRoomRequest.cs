using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.ExtensionRoom.Request
{
    public class CreateExtensionRoomRequest
    {
        public string NameVI { get; set; }
        public string NameEN { get; set; }
        public int ExtensionType_Id { get; set; }
    }
}
