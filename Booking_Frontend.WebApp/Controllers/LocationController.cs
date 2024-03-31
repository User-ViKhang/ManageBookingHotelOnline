using Booking_Backend.Repository.Hotels.Request;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class LocationController : Controller
    {
        private readonly IHotelClientService _hotelClientService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LocationController(IHotelClientService hotelClientService, IHttpContextAccessor httpContextAccessor)
        {
            _hotelClientService = hotelClientService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SearchResult(string locationName, DateTime dateCheckIn, DateTime dateCheckOut, int totalPeople)
        {
            _httpContextAccessor.HttpContext.Session.SetString("date-checkin", dateCheckIn.ToString());
            _httpContextAccessor.HttpContext.Session.SetString("date-checkout", dateCheckOut.ToString());
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var request = new GetHotelByLocationRequest()
            {
                PageIndex = 1,
                PageSize = 10,
                LanguageId = CultureInfo.CurrentCulture.Name,
                LocationName = locationName,
                DateCheckIn = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkin")),
                DateCheckOut = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkout")),
                TotalPeople = totalPeople
            };
            var data = await _hotelClientService.GetHotelByLocation(request);
            var hotelLocationViewModel = new LocationViewModel()
            {
                ListHotelByLocation = data
            };
            return View(hotelLocationViewModel);
        }
    }
}
