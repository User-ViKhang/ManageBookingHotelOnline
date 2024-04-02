using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Service.BookingService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingAPIService _bookingAPIService;

        public BookingController(IBookingAPIService bookingAPIService)
        {
            _bookingAPIService = bookingAPIService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(BookingRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.CreateBooking(request);
            if (!result) return BadRequest();
            return Ok(result);
        }
    }
}
