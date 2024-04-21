using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.LocationService;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.Models;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    [Authorize(Roles = "Owner")]
    public class OwnerController : Controller
    {
        private readonly IHotelTypeClientService _hotelType;
        private readonly ILocationClientService _location;
        private readonly IUserAPI _user;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OwnerController(IHotelTypeClientService hotelType, ILocationClientService location, IUserAPI user, IHttpContextAccessor httpContextAccessor)
        {
            _hotelType = hotelType;
            _location = location;
            _user = user;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("/register/economic"), AllowAnonymous]
        public async Task<IActionResult> RegisterOwner()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
            var user = await _user.GetUserById(userId);
            var hoteltypes = await _hotelType.GetHotelType(new GetAllHotelTypePagingRequest {LanguageId = languageId,Keyword = "",PageIndex = 1,PageSize = 20});
            var locations = await _location.GetLocations(languageId);

            return View(new RegisterViewModel
            {
                HotelTypeVMs = hoteltypes,
                LocationVMs = locations,
                UserVM = user
            });
        }
    }
}
