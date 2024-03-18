using Booking_Backend.Repository.BedTypeRepo.Request;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.AdminApp.Service.BedType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class BedTypeController : Controller
    {
        private readonly IBedTypeClientService _bed;

        public BedTypeController(IBedTypeClientService bed)
        {
            _bed = bed;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 5)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var request = new GetBedTypeRequest()
            {
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _bed.GetBedType(request);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int Id, UpdateBedTypeRequest request)
        {
            var isResult = await _bed.UpdateBedType(Id, request);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBedTypeRequest request)
        {
            var isResult = await _bed.CreateBedType(request);
            if (!isResult) return BadRequest();
            return RedirectToAction("index", "bedtype");
        }

        [HttpGet("bedtype/update/{Id}")]
        public async Task<IActionResult> Update(int Id)
        {
            var bedVM = await _bed.GetBedTypeById(Id);
            if (bedVM == null) return BadRequest(bedVM);
            return View(bedVM);
        }
        
        [HttpGet("bedtype/delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var bedVM = await _bed.DeleteBedType(Id);
            if (bedVM == null) return BadRequest(bedVM);
            return View(bedVM);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
