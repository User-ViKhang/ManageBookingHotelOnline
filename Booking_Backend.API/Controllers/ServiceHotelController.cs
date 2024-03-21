using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Service.ServicesHotel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceHotelController : ControllerBase
    {
        private readonly IServiceAPIService _service;

        public ServiceHotelController(IServiceAPIService service)
        {
            _service = service;
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
        
        [HttpGet("{languageId}/{Id}")]
        public async Task<IActionResult> GetServiceHotelById(int Id, string languageId)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _service.GetServiceHotelById(Id, languageId);
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
    }
}
