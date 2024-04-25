using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Backend.Repository.ViewRepo.Request;
using Booking_Frontend.APIIntegration.BookingCartService;
using Booking_Frontend.APIIntegration.CommentService;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.LocationService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.APIIntegration.ViewService;
using Booking_Frontend.WebApp.Models;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelClientService _hotelClient;
        private readonly IHotelTypeClientService _hotelTypeClient;
        private readonly IServiceHotelClientService _service;
        private readonly IRoomClientService _room;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserAPI _user;
        private readonly ILocationClientService _location;
        private readonly IViewClientService _view;
        private readonly ICommentClientService _comment;
        private readonly IBookingCartClientService _cart;

        public HotelController(IHotelClientService hotelClient, IHotelTypeClientService hotelTypeClient, IServiceHotelClientService service, IRoomClientService room, IHttpContextAccessor httpContextAccessor, IUserAPI user, ILocationClientService location, IViewClientService view, ICommentClientService comment, IBookingCartClientService cart)
        {
            _hotelClient = hotelClient;
            _hotelTypeClient = hotelTypeClient;
            _service = service;
            _room = room;
            _httpContextAccessor = httpContextAccessor;
            _user = user;
            _location = location;
            _view = view;
            _comment = comment;
            _cart = cart;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{culture}/hotel/{Id}")]
        public async Task<IActionResult> Detail(int Id, string culture)
        {
            ViewData["check-in"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            ViewData["check-out"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            ViewData["people"] = _httpContextAccessor.HttpContext.Session.GetInt32("total-people");
            var hotelDetail = await _hotelClient.GetHotelById(Id, culture);
            if (hotelDetail == null) return NotFound();
            var rooms = await _room.GetRoomsByHotelIdToExtension(Id, culture);
            var serviceByIdHotel = await _service.GetServiceByHotelId(hotelDetail.Id, culture);
            APIResult<UserViewModel> user = null;
            List<ListBookingCartByUserIdModel> cart = null;
            if (_httpContextAccessor.HttpContext.Session.GetString("UserId_Client") != null)
            {
                var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
                 cart = await _cart.GetAllBookingCartByUserId(Guid.Parse(userId));

                user = await _user.GetUserById(userId);
            }
            var comments = await _comment.GetAllCommentByHotelId(Id);
            var data = new DetailViewModel()
            {
                HotelDetail = hotelDetail,
                ServiceHotels = serviceByIdHotel,
                Rooms = rooms,
                UserClient = user,
                GetAllCommentByHotelId = comments,
                GetAllBookingCartByUserId = cart
            };
            return View(data);
        }

        [HttpGet("/info/hotel/{Id}")]
        public async Task<IActionResult> HotelInfo(int Id)
        {
            string UserId_Owner = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var languageId = CultureInfo.CurrentCulture.Name;
            var hotel = await _hotelClient.GetHotelByUserId(Guid.Parse(UserId_Owner), languageId);
            var hoteltypes = await _hotelTypeClient.GetAllHotelType(languageId);
            var locations = await _location.GetLocations(languageId);
            var viewservices = await _view.Get(new GetViewHotelRequest { LanguageId = languageId, Keyword = "", PageIndex = 1, PageSize=10 }) ;
            return View(new NotifyBookingViewModel()
            {
                UserId = UserId_Owner,
                HotelViewModel = hotel,
                AllHotelType = hoteltypes,
                AllLocation = locations,
                AllViewServices = viewservices
            });
        }

        [HttpPost("/profile/hotelinfo/{Id}")]
        public async Task<IActionResult> UpdateHotel(int Id, UpdateHotelRequest request)
        {

            request.LanguageId = CultureInfo.CurrentCulture.Name;
            var updateHotel = _hotelClient.UpdateHotel(Id, request);
            return new RedirectResult($"/info/hotel/{Id}");
        }
    }
}
