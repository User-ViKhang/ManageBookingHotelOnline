using Booking_Backend.Repository.RoomRepo.Request;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Backend.Service.Rooms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomAPIService _room;

        public RoomController(IRoomAPIService room)
        {
            _room = room;
        }

        [HttpGet("{languageId}/hotel-id/{hotelId}")]
        public async Task<IActionResult> GetAllRoomByHotel(int hotelId, string languageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var rooms = await _room.GetAllRoomByIdHotel(hotelId, languageId);
            if(rooms == null) return NotFound();
            return Ok(rooms);
        }

        [HttpGet("{languageId}/room-id/{roomId}")]
        public async Task<IActionResult> GetRoomByRoomId(int roomId, string languageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var room = await _room.GetRoomByRoomId(roomId, languageId);
            if(room == null) return NotFound();
            return Ok(room);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] CreateRoomRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var room = await _room.CreateRoom(request);
            if(!room) return NotFound();
            return Ok(room);
        }

        [HttpGet("{languageId}/extension-manage/{hotelId}")]
        public async Task<IActionResult> GetRoomsByHotelIdToExtension(int hotelId, string languageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var room = await _room.GetRoomsByHotelIdToExtension(hotelId, languageId);
            if(room == null) return NotFound();
            return Ok(room);
        }

        [HttpPut("room-id/{roomId}")]
        public async Task<IActionResult> UpdateRoom(int roomId, RoomViewModel request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var room = await _room.UpdateRoom(roomId, request);
            return Ok(room);
        }


        [HttpPut("room-extension/update/{roomId}")]
        public async Task<IActionResult> PutHotelServices(int roomId, [FromBody] List<int> IdsExtension)
        {
            if (IdsExtension == null || IdsExtension.Count == 0)
            {
                return BadRequest("Danh sách Id Exxtension không được để trống.");
            }

            var result = await _room.UpdateRoom_Extension(IdsExtension, roomId);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Có lỗi xảy ra khi cập nhật dữ liệu.");
            }
        }
    }
}
