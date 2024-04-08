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

        [HttpPost]
        public async Task<IActionResult> CreateBooking(BookingRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.CreateBooking(request);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpGet("{LanguageId}/booking-hotel/{hotelId}")]
        public async Task<IActionResult> GetAllBookingByHotel(int hotelId, string LanguageId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.GetAllBookingOwner(hotelId, LanguageId);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpGet("{LanguageId}/detail-booking/{Id}")]
        public async Task<IActionResult> GetBookingOwnerById(int Id, string LanguageId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _bookingAPIService.GetBookingOwnerById(Id, LanguageId);
            if (result == null) return BadRequest();
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
