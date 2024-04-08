using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Frontend.APIIntegration.BedService;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.FormatMoney;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.RoomType;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    [Authorize(Roles = "Owner")]
    public class HomeOwnerController : Controller
    {
        private readonly IHotelClientService _hotel;
        private readonly IBookingClientService _booking;
        private readonly IRoomClientService _room;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoomTypeClientService _roomType;
        private readonly IBedClientService _bed;
        private readonly IFormatMoney _format;

        public HomeOwnerController(IHotelClientService hotel, IBookingClientService booking, IRoomClientService room, IHttpContextAccessor httpContextAccessor, IRoomTypeClientService roomType, IBedClientService bed, IFormatMoney format)
        {
            _hotel = hotel;
            _booking = booking;
            _room = room;
            _httpContextAccessor = httpContextAccessor;
            _roomType = roomType;
            _bed = bed;
            _format = format;
        }

        public async Task<IActionResult> Index(string Id)
        {
            HttpContext.Session.SetString("UserId", Id);
            var languageId = CultureInfo.CurrentCulture.Name;
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(Id), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            return View(new NotifyBookingViewModel()
            {
                UserId = Id,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking
            });
        }

        [HttpGet("detail-booking/{Id}")]        
        public async Task<IActionResult> DetailBooking(int Id)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetBookingOwnerById(Id, languageId);
            return View(new NotifyBookingViewModel() 
            {
                BookingOwnerDetailViewModel = booking,
                HotelViewModel = hotel
            });
        }

        [HttpPost("detail-booking/confirm/{Id}")]        
        public async Task<IActionResult> ConfirmBooking([FromRoute] int Id, ConfirmBookingRequest request)
        {
            var changeState = await _booking.ConfirmBooking(Id, request);
            if (!changeState) return BadRequest();
            return new RedirectResult($"/detail-booking/{Id}");
        }

        [HttpGet("stateroom-price/{hotelId}")]
        public async Task<IActionResult> StateRoomPrice(int hotelId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);
            var rooms = await _room.GetAllRoomByHotelId(hotelId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                RoomOwnerViewModel = rooms
            });
        }

        [HttpGet("stateroom-price/get-room/{roomId}")]
        public async Task<IActionResult> UpdateRoom(int roomId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);

            var roomTypequest = new GetRoomTypeRequest
            {
                Keyword = "",
                LanguageId = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var bedquest = new GetBedRequest
            {
                Keyword = "",
                Language_Id = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var roomType = await _roomType.GetRoomType(roomTypequest);
            var bed = await _bed.Get(bedquest);

            var room = await _room.GetRoomByRoomId(roomId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                RoomDetailOwnerViewModel = room,
                RoomTypeOwnerViewModel = roomType,
                BedOwnerViewModel = bed,
            });
        }

        [HttpPost("stateroom-price/update-room/{roomId}")]
        public async Task<IActionResult> UpdateRoom(int roomId, RoomViewModel request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updateRoom = await _room.UpdateRoom(roomId, request);
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId);

            var roomTypequest = new GetRoomTypeRequest
            {
                Keyword = "",
                LanguageId = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var bedquest = new GetBedRequest
            {
                Keyword = "",
                Language_Id = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var roomType = await _roomType.GetRoomType(roomTypequest);
            var bed = await _bed.Get(bedquest);

            var room = await _room.GetRoomByRoomId(roomId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                RoomDetailOwnerViewModel = room,
                RoomTypeOwnerViewModel = roomType,
                BedOwnerViewModel = bed,
            });
        }


    }
}
