using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class HotelInfoViewModel
    {
        public int Hotel_Id { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string LanguageId { get; set; }
        public List<int> IdsService { get; set; }
    }
}
