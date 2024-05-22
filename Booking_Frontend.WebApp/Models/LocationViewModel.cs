using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.ViewModel;
using System.Collections.Generic;

namespace Booking_Frontend.WebApp.Models
{
    public class LocationViewModel
    {
        public PageResult<HotelViewModel> ListHotelByLocation { get; set; }
        public List<HotelTypeViewModel> ListHotelType { get; set; }
        public List<HotelTypeViewModel> lstHotelTypeVM;
        public APIResult<UserViewModel> UserClient { get; set; }
        public List<ListBookingCartByUserIdModel> GetAllBookingCartByUserId { get; set; }


    }
}
