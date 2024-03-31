using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelClientService _hotelClient;

        public HotelController(IHotelClientService hotelClient)
        {
            _hotelClient = hotelClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{culture}/hotel/{Id}")]
        public async Task<IActionResult> Detail(int Id, string culture)
        {
            var hotelDetail = await _hotelClient.GetHotelById(Id, culture);
            if (hotelDetail == null) return NotFound();
            var data = new DetailViewModel()
            {
                HotelDetail = hotelDetail
            };
            return View(data);
        }
    }
}
