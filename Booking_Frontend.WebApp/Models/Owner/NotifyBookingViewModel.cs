using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModels;
using Booking_Backend.Repository.UserImage.ViewModel;
using Booking_Backend.Repository.Users.ViewModel;
using System.Collections.Generic;

namespace Booking_Frontend.WebApp.Models.Owner
{
    public class NotifyBookingViewModel
    {
        public HotelOwnerViewModel HotelViewModel { get; set; }
        public HotelTypeOwnerViewModel HotelTypeViewModel { get; set; }
        public UserOwnerViewModel UserViewModel { get; set; }
        public UserImageOwnerViewModel UserImageViewModel { get; set; }
        public List<BookingOwnerViewModel> BookingOwnerViewModel { get; set; }
    }
}
