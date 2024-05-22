using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Service.BookingService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
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

        [HttpPost("{payment}")]
        public async Task<IActionResult> CreateBooking(BookingRequest request, Payment payment)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.CreateBooking(request, payment);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpGet("{LanguageId}/booking-hotel/{hotelId}")]
        public async Task<IActionResult> GetAllBookingByHotel(int hotelId, string LanguageId, StatusBooking? status)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.GetAllBookingOwner(hotelId, LanguageId, status);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpGet("{LanguageId}/booking-bill/{bookingId}")]
        public async Task<IActionResult> GetBillBooking(int bookingId, string LanguageId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.BillClient(bookingId, LanguageId);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpGet("{LanguageId}/detail-booking/{Id}")]
        public async Task<IActionResult> GetBookingOwnerById(int Id, string LanguageId)
        {
            var result = await _bookingAPIService.GetBookingOwnerById(Id, LanguageId);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{LanguageId}/proccess-booking/{Id}")]
        public async Task<IActionResult> GetBookingOwnerById(string Id, string LanguageId)
        {
            var result = await _bookingAPIService.GetBookingOwnerByUserId(Id, LanguageId);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBooking(int roomId, int bookingId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.DeleteBooking(roomId, bookingId);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpPost("confirm/{Id}")]
        public async Task<IActionResult> ConfirmBooking(int Id, ConfirmBookingRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.ConfirmBooking(Id, request);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpPost("check-out/bill")]
        public async Task<IActionResult> Bill(CheckoutRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.CheckoutBooking(request);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpPatch("update-state/{Id}")]
        public async Task<IActionResult> UpdateStatusBooking(int Id, StatusBooking status)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _bookingAPIService.ChangeStatusBooking(Id, status);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
    }
}
