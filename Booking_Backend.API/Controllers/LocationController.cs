using Booking_Backend.Service.LocationServices;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationAPIService _locAPIService;

        public LocationController(ILocationAPIService locAPIService)
        {
            _locAPIService = locAPIService;
        }

        [HttpGet("{Language_Id}")]
        public async Task<IActionResult> GetLocations(string Language_Id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var locations = await _locAPIService.GetLocations(Language_Id);
            if (locations == null) throw new BookingException("Location is not found ");
            return Ok(locations);
        }

    }
}
