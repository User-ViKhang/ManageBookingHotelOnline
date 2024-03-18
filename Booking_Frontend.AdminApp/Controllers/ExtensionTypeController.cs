using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.AdminApp.Service.ExtensionTypeRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class ExtensionTypeController : Controller
    {
        private readonly IExtensionTypeRoomClientService _ex;

        public ExtensionTypeController(IExtensionTypeRoomClientService ex)
        {
            _ex = ex;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 5)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var request = new GetExtensionTypeRoomRequest()
            {
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _ex.GetExtensionTypeRoom(request);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateExtensionTypeRoomRequest request)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            request.LanguageId = languageId;
            var isResult = await _ex.CreateExtensionTypeRoom(request);
            if (!isResult) return BadRequest();
            return RedirectToAction("index", "servicehotel");
        }

        [HttpPost]
        public async Task<IActionResult> Update(int Id, UpdateExtensionTypeRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _ex.UpdateExtensionTypeRoom(Id, request);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("Index");
        }

        [HttpGet("extensiontype/delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var isResult = await _ex.DeleteExtensionTypeRoom(Id);
            if (!isResult) return BadRequest();
            return RedirectToAction("index", "extensiontype");
        }
    }
}
