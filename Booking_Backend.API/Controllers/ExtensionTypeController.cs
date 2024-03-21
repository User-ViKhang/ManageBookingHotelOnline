using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Service.ExtensionTypeRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtensionTypeController : ControllerBase
    {
        private readonly IExtensionTypeRoomAPIService _ex;

        public ExtensionTypeController(IExtensionTypeRoomAPIService ex)
        {
            _ex = ex;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetExtensionType([FromQuery] GetExtensionTypeRoomRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var extensionType = await _ex.GetExtensionTypeRoom(request);
            if(extensionType == null) return NotFound();
            return Ok(extensionType);
        }
       
        [HttpGet]
        public async Task<IActionResult> GetAll(string languageId) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var extensionType = await _ex.GetAll(languageId);
            if(extensionType == null) return NotFound();
            return Ok(extensionType);
        }
 
        [HttpPost]
        public async Task<IActionResult> CreateExtensionType([FromBody] CreateExtensionTypeRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _ex.CreateExtensionTypeRoom(request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

        
        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, [FromBody] UpdateExtensionTypeRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _ex.UpdateExtensionTypeRoom(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _ex.DeleteExtensionTypeRoom(Id);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
    }
}
