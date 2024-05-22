using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.ViewRepo.Request;
using Booking_Backend.Service.ViewHotelService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewServiceController : ControllerBase
    {
        private readonly IViewHotelAPIService _view;

        public ViewServiceController(IViewHotelAPIService view)
        {
            _view = view;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelType([FromQuery] GetViewHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _view.Get(request);
            if (result == null) return BadRequest();
            return Ok(result);
        }
    }
}
