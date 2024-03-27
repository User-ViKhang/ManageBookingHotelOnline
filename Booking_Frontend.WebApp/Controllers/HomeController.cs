using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.WebApp.Models;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly IHotelTypeClientService _hotelType;

        public HomeController(ILogger<HomeController> logger, ISharedCultureLocalizer loc, IHotelTypeClientService hotelType)
        {
            _logger = logger;
            _loc = loc;
            _hotelType = hotelType;
        }

        public async Task<IActionResult> Index()
        {
            //var msg = _loc.GetLocalizedString("Đà Nẳng");
            var languageId = CultureInfo.CurrentCulture.Name;
            var lst = await _hotelType.GetAllHotelType(languageId);
            var data = new HomeViewModel()
            {
                lstHotelTypeVM = lst
            };
            return View(data);
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return LocalRedirect(returnUrl);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
