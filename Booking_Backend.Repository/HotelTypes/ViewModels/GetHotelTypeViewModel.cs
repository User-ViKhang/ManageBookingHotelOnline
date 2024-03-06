using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.ViewModel
{
    public class GetHotelTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Language { get; set; }
    }
}
