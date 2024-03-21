using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Users.Request;
using Booking_Frontend.AdminApp.Service.HotelType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class HotelTypeController : Controller
    {
        private readonly IHotelTypeClientService _hotelTypeClientService;

        public HotelTypeController(IHotelTypeClientService hotelTypeClientService)
        {
            _hotelTypeClientService = hotelTypeClientService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 5)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var request = new GetAllHotelTypePagingRequest()
            {
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _hotelTypeClientService.GetHotelType(request);
            return View(data);
        }

        [HttpPost, Consumes("multipart/form-data")]
        public async Task<IActionResult> Update(int Id, [FromForm] UpdateHotelTypeRequest request)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            request.Language_Id = languageId;
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _hotelTypeClientService.UpdateHotelType(Id, request);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("Index");
        }
        
        [HttpPost, Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] CreateHotelTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _hotelTypeClientService.CreateHotelType(request);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("Index");
        }

        [HttpGet("hoteltype/delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _hotelTypeClientService.DeleteHotelType(Id);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("Index");
        }
    }
}