using Booking_Backend.Repository.Hotels.Request;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class PageController : Controller
    {
        private readonly IHotelClientService _hotel;

        public PageController(IHotelClientService hotel)
        {
            _hotel = hotel;
        }

        public IActionResult BookingSuccess()
        {
            return View();
        }

        [HttpPost("/sendrequest")]
        public async Task<IActionResult> RegisterOwnerSuccess(InfoOwnerRegisterViewModel infoModel)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            HttpContext.Session.Clear();
            var createHotel = await _hotel.RegisterHotel(infoModel);
            return View(infoModel);
        }
    }
}
