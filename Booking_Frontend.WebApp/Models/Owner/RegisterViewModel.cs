using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.LocationRepo.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Booking_Backend.Repository.Users.ViewModel;

namespace Booking_Frontend.WebApp.Models.Owner
{
    public class RegisterViewModel
    {
        public APIResult<UserViewModel> UserVM { get; set; }
        public PageResult<HotelTypeViewModel> HotelTypeVMs { get; set; }
        public List<Booking_Backend.Repository.LocationRepo.ViewModel.LocationViewModel> LocationVMs { get; set; }
    }
}
