using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Service.BedService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BedController : ControllerBase
    {
        private readonly IBedAPIService _bed;

        public BedController(IBedAPIService bed)
        {
            _bed = bed;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetBedRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var bed = await _bed.Get(request);
            if (bed == null) return NotFound();
            return Ok(bed);

        }
        
        [HttpGet("{languageId}/{Id}")]
        public async Task<IActionResult> GetById(int Id, string languageId) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var bed = await _bed.GetById(Id, languageId);
            if (bed == null) return NotFound();
            return Ok(bed);

        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBedRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var bed = await _bed.Create(request);
            if (!bed) return NotFound();
            return Ok(bed);

        }
        
        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, [FromBody] UpdateBedRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var bed = await _bed.Update(Id, request);
            if (!bed) return NotFound();
            return Ok(bed);

        }
        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var bed = await _bed.Delete(Id);
            if (!bed) return NotFound();
            return Ok(bed);

        }

    }
}
