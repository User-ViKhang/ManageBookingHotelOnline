using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.RoomRepo.Request
{
    public class CreateRoomRequest
    {
        public string RoomCode { get; set; }
        public string LanguageId { get; set; }
        public int RoomTypeId { get; set; }
        public int HotelId { get; set; }
        public int BedId { get; set; }
        public decimal PriceOld { get; set; }
        public decimal Price { get; set; }
        public int Maximum { get; set; }
        public List<int> Ids { get; set; }
    }
}
