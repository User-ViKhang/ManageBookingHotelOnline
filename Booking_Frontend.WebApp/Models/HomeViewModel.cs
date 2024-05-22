using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Users.ViewModel;
using System.Collections.Generic;

namespace Booking_Frontend.WebApp.Models
{
    public class HomeViewModel
    {
        public List<HotelTypeViewModel> lstHotelTypeVM;
        public APIResult<UserViewModel> UserClient { get; set; }
    }
}
