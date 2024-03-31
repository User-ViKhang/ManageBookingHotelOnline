using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Service.Hotels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelAPIService _hotelAPIService;

        public HotelController(IHotelAPIService hotelAPIService)
        {
            _hotelAPIService = hotelAPIService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelByLocation([FromQuery] GetHotelByLocationRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetHotelByLocation(request);
            if (data == null) return BadRequest();
            return Ok(data);
        }

        [HttpGet("{LanguageId}/{Id}")]
        public async Task<IActionResult> GetHotelById(int Id, string LanguageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetHotelById(Id, LanguageId);
            if (data == null) return BadRequest();
            return Ok(data);
        }
    }
}
