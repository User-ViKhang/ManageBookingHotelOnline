using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.AdminApp.Service.RoomType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class RoomTypeController : Controller
    {
        private readonly IRoomTypeClientService _roomTypeClientService;

        public RoomTypeController(IRoomTypeClientService roomTypeClientService)
        {
            _roomTypeClientService = roomTypeClientService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 5)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var request = new GetRoomTypeRequest()
            {
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _roomTypeClientService.GetRoomType(request);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int Id, [FromForm] UpdateRoomTypeRrequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _roomTypeClientService.UpdateRoomType(Id, request);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateRoomTypeRequest request)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var isResult = await _roomTypeClientService.CreateRoomType(request);
            if (!isResult) return BadRequest();
            return RedirectToAction("index", "roomtype");
        }

        [HttpGet("roomtype/delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var isResult = await _roomTypeClientService.DeleteRoomType(Id);
            if (!isResult) return BadRequest();
            return RedirectToAction("index", "roomtype");
        }
    }
}
