using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.RoomType.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Service.RoomTypeHotel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeAPIService _roomTypeAPIService;

        public RoomTypeController(IRoomTypeAPIService roomTypeAPIService)
        {
            _roomTypeAPIService = roomTypeAPIService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoomType([FromQuery] GetRoomTypeRequest request)
        {
            var lstRoomType = await _roomTypeAPIService.GetRoomTypes(request);
            if (lstRoomType == null) return BadRequest();
            return Ok(lstRoomType);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, UpdateRoomTypeRrequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _roomTypeAPIService.UpdateRoomTypes(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRoomTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _roomTypeAPIService.CreateRoomType(request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Create(int Id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _roomTypeAPIService.DeleteRoomType(Id);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
    }
}
