using Booking_Frontend.APIIntegration.BedService;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.RoomType;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using System.Threading.Tasks;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Booking_Backend.Repository.Service.Request;
using System.Collections.Generic;
using Booking_Frontend.APIIntegration.ExtensionTypeRoom;

namespace Booking_Frontend.WebApp.Controllers
{
    public class ExtensionServiceController : Controller
    {
        private readonly IHotelClientService _hotel;
        private readonly IBookingClientService _booking;
        private readonly IRoomClientService _room;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoomTypeClientService _roomType;
        private readonly IBedClientService _bed;
        private readonly IServiceHotelClientService _service;
        private readonly IExtensionTypeRoomClientService _extension;

        public ExtensionServiceController(IHotelClientService hotel, IBookingClientService booking, IRoomClientService room, IHttpContextAccessor httpContextAccessor, IRoomTypeClientService roomType, IBedClientService bed, IServiceHotelClientService service, IExtensionTypeRoomClientService extension)
        {
            _hotel = hotel;
            _booking = booking;
            _room = room;
            _httpContextAccessor = httpContextAccessor;
            _roomType = roomType;
            _bed = bed;
            _service = service;
            _extension = extension;
        }

        [HttpGet("extension-service")]
        public async Task<IActionResult> Index()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var hotel_services = await _service.GetAllServiceHotelByIdHotel(hotel.Id);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var services = await _service.GetServiceHotel(new GetServiceHotelRequest
            {
                LanguageId = languageId,
                Keyword = "",
                PageIndex = 1,
                PageSize = 100
            });
            return View(new NotifyBookingViewModel()
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                ServiceOwnerViewModel = services,
                ServiceIdsChecked = hotel_services

            });
        }
        
        [HttpGet("extension-manage")]
        public async Task<IActionResult> ManageExtension()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var extensiongroup = await _extension.GetExtensionGroup(languageId);
            var extensionChecked = await _room.GetRoomsByHotelIdToExtension( hotel.Id, languageId);
            var services = await _service.GetServiceHotel(new GetServiceHotelRequest
            {
                LanguageId = languageId,
                Keyword = "",
                PageIndex = 1,
                PageSize = 100
            });
            return View(new NotifyBookingViewModel()
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                ServiceOwnerViewModel = services,
                ExtensionGroupViewModel = extensiongroup,
                ExtensionChecked = extensionChecked
            });
        }
        
        [HttpPost("extension-service/update/{hotelId}")]
        public async Task<IActionResult> UpdatePost(List<int> Ids, int hotelId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var isUpdateResult = await _service.UpdateService_Hotel(Ids, hotelId);
            var hotel_services = await _service.GetAllServiceHotelByIdHotel(hotelId);
            var services = await _service.GetServiceHotel(new GetServiceHotelRequest
            {
                LanguageId = languageId,
                Keyword = "",
                PageIndex = 1,
                PageSize = 100
            });
            return new RedirectResult("/extension-manage");
        }
        
        
        [HttpPost("extension-room/update/{roomId}")]
        public async Task<IActionResult> ManageExtension(List<int> Ids, int roomId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var updateRoom_Extension = await _room.UpdateExtension_Room(Ids, roomId);
            var extensiongroup = await _extension.GetExtensionGroup(languageId);
            var extensionChecked = await _room.GetRoomsByHotelIdToExtension(hotel.Id, languageId);
            var services = await _service.GetServiceHotel(new GetServiceHotelRequest
            {
                LanguageId = languageId,
                Keyword = "",
                PageIndex = 1,
                PageSize = 100
            });
            return View(new NotifyBookingViewModel()
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                ServiceOwnerViewModel = services,
                ExtensionGroupViewModel = extensiongroup,
                ExtensionChecked = extensionChecked
            });
        }
    }
}
