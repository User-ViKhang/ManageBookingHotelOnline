using Booking_Frontend.APIIntegration.HotelService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    [Authorize(Roles = "Owner")]
    public class HomeOwnerController : Controller
    {
        private readonly IHotelClientService _hotel;

        public HomeOwnerController(IHotelClientService hotel)
        {
            _hotel = hotel;
        }

        public async Task<IActionResult> Index(string Id)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(Id), languageId);
            return View();
        }
    }
}
