using Booking_Backend.Data.EF;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class ServiceHotelController : Controller
    {
        private readonly IServiceHotelClientService _serviceHotelClientService;

        public ServiceHotelController(IServiceHotelClientService serviceHotelClientService)
        {
            _serviceHotelClientService = serviceHotelClientService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 5)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var request = new GetServiceHotelRequest()
            {
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _serviceHotelClientService.GetServiceHotel(request);
            return View(data);
        }

        [HttpGet("servicehotel/update/{Id}")]
        public async Task<IActionResult> Update(int Id)
        {
            var languageId = HttpContext.Session.GetString("DefaultLanguageId");
            var serviceHotel = await _serviceHotelClientService.GetServiceHotelById(languageId, Id);
            return View(serviceHotel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int Id, UpdateServiceHotelRequest request)
        {
            var languageId  = HttpContext.Session.GetString("DefaultLanguageId");
            request.Language = languageId;
            var isResult = await _serviceHotelClientService.UpdateServiceHotel(Id, request);
            if (!isResult) return BadRequest(isResult);
            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceHotelRequest request)
        {
            var isResult = await _serviceHotelClientService.CreateServiceHotel(request);
            if (!isResult) return BadRequest();
            return RedirectToAction("create", "servicehotel");
        }

        [HttpGet("servicehotel/delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var isResult =await _serviceHotelClientService.DeleteServiceHotel(Id);
            if (!isResult) return BadRequest();
            return RedirectToAction("index", "servicehotel");
        }
    }
}
