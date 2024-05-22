using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.HotelTypes.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.ViewModel
{
    public class HotelTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Language_Id { get; set; }
    }
}