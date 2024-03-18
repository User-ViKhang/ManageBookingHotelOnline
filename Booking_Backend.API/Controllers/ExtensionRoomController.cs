using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Service.ExtensionRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtensionRoomController : ControllerBase
    {
        private readonly IExtensionRoomAPIService _extensionRoomAPIService;

        public ExtensionRoomController(IExtensionRoomAPIService extensionRoomAPIService)
        {
            _extensionRoomAPIService = extensionRoomAPIService;
        }

        [HttpGet]
        public async Task<IActionResult> GetExtensionRoom([FromQuery] GetExtensionRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var extensionRoom = await _extensionRoomAPIService.GetExtensionRoom(request);
            if (extensionRoom == null) return NotFound();
            return Ok(extensionRoom);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateExtensionRoom([FromBody] CreateExtensionRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var extensionRoom = await _extensionRoomAPIService.CreateExtensionRoom(request);
            if (!extensionRoom) return BadRequest();
            return Ok(extensionRoom);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteExtensionRoom(int Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var extensionRoom = await _extensionRoomAPIService.DeleteExtensionRoom(Id);
            if (!extensionRoom) return BadRequest();
            return Ok(extensionRoom);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateExtensionRoom(int Id, [FromBody] UpdateExtensionRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var extensionRoom = await _extensionRoomAPIService.UpdateExtensionRoom(Id, request);
            if (!extensionRoom) return BadRequest();
            return Ok(extensionRoom);
        }
    }
}
