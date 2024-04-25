using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Thumbnail { get; set; }
        public string HotelTypeName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int? Preview { get; set; }
        public decimal? Score { get; set; }
        public decimal? PriceDefault { get; set; }
    }
}
