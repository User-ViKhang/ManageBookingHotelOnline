using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Service.Hotels;
using Booking_Backend.Service.ServicesHotel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceHotelController : ControllerBase
    {
        private readonly IServiceAPIService _service;
        private readonly IHotelAPIService _hotel;

        public ServiceHotelController(IServiceAPIService service, IHotelAPIService hotel)
        {
            _service = service;
            _hotel = hotel;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateServiceHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _service.CreateServiceHotel(request);
            if(!isResult) return BadRequest();
            return Ok(isResult);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetServiceHotel([FromQuery] GetServiceHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _service.GetServiceHotel(request);
            if(result==null) return BadRequest();
            return Ok(result);
        }
        
        [HttpGet("{languageId}/service-hotel/{hotelId}")]
        public async Task<IActionResult> GetServiceByHotelId(int hotelId, string languageId)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _service.GetServiceByHotelId(hotelId, languageId);
            if(result==null) return BadRequest();
            return Ok(result);
        }
        
        [HttpGet("{languageId}/{Id}")]
        public async Task<IActionResult> GetServiceHotelById(int Id, string languageId)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _service.GetServiceHotelById(Id, languageId);
            if(result==null) return BadRequest();
            return Ok(result);
        }
        
        [HttpGet("hotel/{IdHotel}")]
        public async Task<IActionResult> GetServiceHotelById(int IdHotel)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _service.GetAllServiceHotelByIdHotel(IdHotel);
            if(result==null) return BadRequest();
            return Ok(result);
        }
        
        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, UpdateServiceHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _service.UpdateServiceHotel(Id, request);
            if(!isResult) return BadRequest();
            return Ok(isResult);
        }
        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _service.DeleteServiceHotel(Id);
            if(!isResult) return BadRequest();
            return Ok(isResult);
        }

        [HttpPut("service-hotel/update/{hotelId}")]
        public async Task<IActionResult> PutHotelServices(int hotelId, [FromBody] HotelInfoViewModel hotelVM)
        {
            if (hotelVM.IdsService == null || hotelVM.IdsService.Count == 0)
            {
                await _hotel.ChangeDes(hotelId, hotelVM.Description, hotelVM.LanguageId);
                return BadRequest("Danh sách Id Service không được để trống.");
            }
            await _hotel.ChangeDes(hotelId, hotelVM.Description, hotelVM.LanguageId);
            var result = await _service.UpdateServiceHotel(hotelVM, hotelId);
            if(!result) return BadRequest();
            return Ok();
            
        }
    }
}
