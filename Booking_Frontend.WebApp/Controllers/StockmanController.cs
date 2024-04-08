using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using Booking_Frontend.APIIntegration.BedService;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.ExtensionTypeRoom;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.RoomType;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Booking_Backend.Repository.Hotels.Request;

namespace Booking_Frontend.WebApp.Controllers
{

    public class StockmanController : Controller
    {
        private readonly IHotelClientService _hotel;
        private readonly IBookingClientService _booking;
        private readonly IRoomClientService _room;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoomTypeClientService _roomType;
        private readonly IBedClientService _bed;

        public StockmanController(IHotelClientService hotel, IBookingClientService booking, IRoomClientService room, IHttpContextAccessor httpContextAccessor, IRoomTypeClientService roomType, IBedClientService bed)
        {
            _hotel = hotel;
            _booking = booking;
            _room = room;
            _httpContextAccessor = httpContextAccessor;
            _roomType = roomType;
            _bed = bed;
        }

        [HttpGet("store-picture")]
        public async Task<IActionResult> Index()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var images = await _hotel.GetListImageHotel(hotel.Id);

            return View(new NotifyBookingViewModel()
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                Images = images

            });
        }
        
        [HttpPost("/store-picture/update-thumbnail"), Consumes("multipart/form-data")]
        public async Task<IActionResult> Index(CreateImageHotelRequest request)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var updateThumbnailHotel = await _hotel.CreateImageThumbnailHotel(hotel.Id, request);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var images = await _hotel.GetListImageHotel(hotel.Id);

            return View(new NotifyBookingViewModel()
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                Images = images
            });
        }
        
        [HttpPost("/store-picture/update-image/{Id}"), Consumes("multipart/form-data")]
        public async Task<IActionResult> Index(int Id, CreateImageHotelRequest request)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var createImage = await _hotel.CreateImageHotel(Id, request);
            var images = await _hotel.GetListImageHotel(hotel.Id);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            return View(new NotifyBookingViewModel()
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                Images = images
            });
        }

        [HttpGet("delete-img/{Id}")]
        public async Task<IActionResult> RemoveImage(int Id)
        {
            var delete = await _hotel.DeleteHotelImage(Id);
            return new RedirectResult("/store-picture");
        }

    }
}
