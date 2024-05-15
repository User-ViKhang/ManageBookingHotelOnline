using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.ViewModels
{
    public class HotelOwnerViewModel
    {
        public int Id { get; set; }
        public string Hotline { get; set; }
        public DateTime Establish { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string? Thumbnail { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string? ShortDescription { get; set; }
        public string Language_Id { get; set; }
        public int? HotelTypeId { get; set; }
        public int? ViewHotelId { get; set; }
        public int? LocationId { get; set; }

    }
}
