using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Frontend.AdminApp.Service.BedService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class BedController : Controller
    {
        private readonly IBedClientService _bed;

        public BedController(IBedClientService bed)
        {
            _bed = bed;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 5)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var request = new GetBedRequest()
            {
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Language_Id = languageId
            };
            var data = await _bed.Get(request);
            return View(data);
        }

        [HttpGet("bed/update/{Id}")]
        public async Task<IActionResult> Update(int Id)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var bed = await _bed.GetById(Id, languageId);
            return View(bed);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int Id, UpdateBedRequest request)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            request.Language_Id = languageId;
            var bed = await _bed.Update(Id, request);
            return RedirectToAction("index");
        }
    }
}
