using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Service.BillService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillAPIService _bill;

        public BillController(IBillAPIService bill)
        {
            _bill = bill;
        }

        [HttpGet]
        public async Task<IActionResult> CreateBill(int bookingId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bill.CreateBill(bookingId);
            if (!result) return BadRequest();
            return Ok(result);
        }
    }
}
