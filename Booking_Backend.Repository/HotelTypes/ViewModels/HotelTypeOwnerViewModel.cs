using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.HotelTypes.ViewModels
{
    public class HotelTypeOwnerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }
    }
}
