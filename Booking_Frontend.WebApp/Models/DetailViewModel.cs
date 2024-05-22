using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.CommentRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Models
{
    public class DetailViewModel
    {
        public HotelDetailViewModel HotelDetail { get; set; }
        public List<ServiceHotelViewModel> ServiceHotels { get; set; }
        public List<Room> Rooms { get; set; }
        public List<HotelTypeViewModel> lstHotelTypeVM;
        public APIResult<UserViewModel> UserClient { get; set; }
        public UpdateProfileRequest UpdateProfileRequestModel { get; set; }
        public List<CommentViewModel> GetAllCommentByHotelId { get; set; }
        public List<ListBookingCartByUserIdModel> GetAllBookingCartByUserId { get; set; }
        public List<BookingOwnerViewModel> GetAllBookingByUserId { get; set; }
        public List<BookingHistoriesViewModel> BookingHistoriesViewModel { get; set; }
        public List<Comment_User> CommentLike { get; set; }


    }
}
