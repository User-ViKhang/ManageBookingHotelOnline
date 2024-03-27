using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using Booking_Frontend.APIIntegration.ExtensionTypeRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class ExtensionRoomController : Controller
    {
        private readonly IExtensionRoomClientService _extensionRoomClientService;
        private readonly IExtensionTypeRoomClientService _extensionTypeRoomClientService;

        public ExtensionRoomController(IExtensionRoomClientService extensionRoomClientService, IExtensionTypeRoomClientService extensionTypeRoomClientService)
        {
            _extensionRoomClientService = extensionRoomClientService;
            _extensionTypeRoomClientService = extensionTypeRoomClientService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int extensiontypeId, string key, int pageIndex = 1, int pageSize = 5)
        {
            if(extensiontypeId <= 0)
            {
                extensiontypeId = 2;
            }
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var lstExtensionType = await _extensionTypeRoomClientService.GetAll(languageId);
            ViewBag.ExtensionTypes = lstExtensionType.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            var request = new GetExtensionRoomRequest()
            {
                Keyword = key,
                ExtensionTypeId = extensiontypeId,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _extensionRoomClientService.GetExtensionRoom(request);
            return View(data);
        }

        [HttpGet] // Hiện View
        public async Task<IActionResult> Create()
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var extensionTypeVM = await _extensionTypeRoomClientService.GetAll(languageId);
            ViewBag.ExtensionTypeVM = extensionTypeVM.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        [HttpPost] // Xử lí nghiệp vụ tạo mới
        public async Task<IActionResult> Create(CreateExtensionRoomRequest request)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _extensionRoomClientService.CreateExtensionRoom(request);
            if (!isResult) return BadRequest();
            return RedirectToAction("index");
        }
        
        [HttpPost] // Xử lí nghiệp vụ tạo mới
        public async Task<IActionResult> Update(int Id, UpdateExtensionRoomRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _extensionRoomClientService.UpdateExtensionRoom(Id, request);
            if (!isResult) return BadRequest();
            return RedirectToAction("index");
        }
        
        [HttpGet("extensionroom/delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _extensionRoomClientService.DeleteExtensionRoom(Id);
            if (!isResult) return BadRequest();
            return RedirectToAction("index");
        }

    }
}
