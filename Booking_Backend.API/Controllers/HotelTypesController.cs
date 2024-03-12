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

        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllHotelType(string languageId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var listAllHotelType = await _hotelTypeService.GetAllHotelType(languageId);
            return Ok(listAllHotelType);
        }

        [HttpPost("{languageId}")]
        public async Task<IActionResult> CreateHotelType(string languageId, [FromBody] CreateHotelTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _hotelTypeService.CreateHotelType(request);
            if (!result.IsSuccessed) return BadRequest(result.IsSuccessed);
            return Ok(result.ResultOject);
        }
    }
}