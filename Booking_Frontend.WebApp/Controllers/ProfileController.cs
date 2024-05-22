using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Frontend.APIIntegration.BookingCartService;
using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.Profile;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.Models;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly IHotelTypeClientService _hotelType;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserAPI _user;
        private readonly IProfileClientService _profile;
        private readonly IBookingCartClientService _cart;

        public ProfileController(ILogger<HomeController> logger, ISharedCultureLocalizer loc, IHotelTypeClientService hotelType, IHttpContextAccessor httpContextAccessor, IUserAPI user, IProfileClientService profile, IBookingCartClientService cart)
        {
            _logger = logger;
            _loc = loc;
            _hotelType = hotelType;
            _httpContextAccessor = httpContextAccessor;
            _user = user;
            _profile = profile;
            _cart = cart;
        }

        public async Task<IActionResult> Index()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
            var user = await _user.GetUserById(userId);
            var requestUpdateVM = new UpdateProfileRequest
            {
                Address = user.ResultOject.Address,
                Birthday = user.ResultOject.Birthday,
                AvatarUrl = user.ResultOject.AvatarUrl,
                Dashboard = user.ResultOject.Dashboard,
                DisplayName = user.ResultOject.DisplayName,
                FirstName = user.ResultOject.FirstName,
                Gender = user.ResultOject.Gender,
                LastName = user.ResultOject.LastName,
                Nation = user.ResultOject.Nation,
                PhoneNumber = user.ResultOject.PhoneNumber,
                UserName = user.ResultOject.UserName,
                Email = user.ResultOject.Email
            };
            var card = await _cart.GetAllBookingCartByUserId(Guid.Parse(userId));
            var data = new DetailViewModel()
            {
                UpdateProfileRequestModel = requestUpdateVM,
                UserClient = user,
                GetAllBookingCartByUserId = card
            };
            return View(data);
        }

        [HttpPost("profile"), Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateUser(UpdateProfileRequest request)
        {
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
            var upddateUser = await _profile.UpdateProfile(userId, request);
            return new RedirectResult("/profile");
        }
    }
}
