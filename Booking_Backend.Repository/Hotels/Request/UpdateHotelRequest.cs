using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.Request
{
    public class UpdateHotelRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public DateTime Establish { get; set; }
        public int HotelTypeId { get; set; }
        public int LocationId { get; set; }
        public int ViewId { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string LanguageId { get; set; }
    }
}
