using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Booking_Frontend.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelClientService _hotelClient;
        private readonly IServiceHotelClientService _service;
        private readonly IRoomClientService _room;

        public HotelController(IHotelClientService hotelClient, IServiceHotelClientService service, IRoomClientService room)
        {
            _hotelClient = hotelClient;
            _service = service;
            _room = room;
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
            var rooms = await _room.GetRoomsByHotelIdToExtension(Id, culture);
            var serviceByIdHotel = await _service.GetServiceByHotelId(hotelDetail.Id, culture);
            var data = new DetailViewModel()
            {
                HotelDetail = hotelDetail,
                ServiceHotels = serviceByIdHotel,
                Rooms = rooms
            };
            return View(data);
        }
    }
}
