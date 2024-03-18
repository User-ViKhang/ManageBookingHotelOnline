using Booking_Backend.Repository.BedTypeRepo.Request;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Service.BedTypeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BedController : ControllerBase
    {
        private readonly IBedTypeAPIService _bed;

        public BedController(IBedTypeAPIService bed)
        {
            _bed = bed;
        }

        [HttpGet]
        public async Task<IActionResult> GetBedType([FromQuery] GetBedTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bed.GetBedType(request);
            if (result == null) return BadRequest();
            return Ok(result);
        }
        
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBedTypeById(int Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bed.GetBedTypeById(Id);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, UpdateBedTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _bed.UpdateBedType(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _bed.DeleteBedType(Id);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(CreateBedTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _bed.CreateBedType(request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

    }
}
