using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.BedRepo.ViewModel;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Backend.Repository.RoomType.ViewModel;
using Booking_Backend.Repository.Service.ViewModel;
using Booking_Backend.Repository.UserImage.ViewModel;
using Booking_Backend.Repository.Users.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Booking_Frontend.WebApp.Models.Owner
{
    public class NotifyBookingViewModel
    {
        public string UserId { get; set; }
        public HotelOwnerViewModel HotelViewModel { get; set; }
        public HotelTypeOwnerViewModel HotelTypeViewModel { get; set; }
        public UserOwnerViewModel UserViewModel { get; set; }
        public UserImageOwnerViewModel UserImageViewModel { get; set; }
        public List<BookingOwnerViewModel> BookingOwnerViewModel { get; set; }
        public BookingOwnerViewModel BookingOwnerDetailViewModel { get; set; }
        public APIResult<List<RoomViewModel>> RoomOwnerViewModel { get; set; }
        public APIResult<RoomViewModel> RoomDetailOwnerViewModel { get; set; }
        public PageResult<RoomTypeViewModel> RoomTypeOwnerViewModel { get; set; }
        public PageResult<BedViewModel> BedOwnerViewModel { get; set; }
        public PageResult<ServiceHotelViewModel> ServiceOwnerViewModel { get; set; }
        public List<int> ServiceIdsChecked { get; set; }
        public List<ExtensionType> ExtensionGroupViewModel { get; set; }
        public List<Room> ExtensionChecked { get; set; }
        public List<Image> Images { get; set; }

    }
}
