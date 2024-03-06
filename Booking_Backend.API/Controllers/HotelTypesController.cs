using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Service.HotelTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelTypesController : ControllerBase
    {
        private readonly IHotelTypeService _hotelTypeService;

        public HotelTypesController(IHotelTypeService hotelTypeService)
        {
            _hotelTypeService = hotelTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotelType()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var listAllHotelType = await _hotelTypeService.GetAllHotelType();
            return Ok(listAllHotelType);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotelType([FromBody] CreateHotelTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _hotelTypeService.CreateHotelType(request);
            if(!result.IsSuccessed) return BadRequest(result.IsSuccessed);
            return Ok(result.ResultOject);
        }
    }
}
