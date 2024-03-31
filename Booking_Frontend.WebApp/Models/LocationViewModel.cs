using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using System.Collections.Generic;

namespace Booking_Frontend.WebApp.Models
{
    public class LocationViewModel
    {
        public PageResult<HotelViewModel> ListHotelByLocation { get; set; }
    }
}
