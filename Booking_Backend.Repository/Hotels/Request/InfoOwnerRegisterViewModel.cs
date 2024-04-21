using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.Request
{
    public class InfoOwnerRegisterViewModel
    {
        public int HotelTypeId { get; set; }
        public int LocationId { get; set; }
        public string HotelNameVI { get; set; }
        public string HotelNameEN { get; set; }
        public string OwnerName { get; set; }
        public string UserId { get; set; }
    }
}
