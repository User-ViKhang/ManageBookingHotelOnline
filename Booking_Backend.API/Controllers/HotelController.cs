using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Service.Hotels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelAPIService _hotelAPIService;

        public HotelController(IHotelAPIService hotelAPIService)
        {
            _hotelAPIService = hotelAPIService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelByLocation([FromQuery] GetHotelByLocationRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetHotelByLocation(request);
            if (data == null) return BadRequest();
            return Ok(data);
        }

        [HttpGet("{LanguageId}/{Id}")]
        public async Task<IActionResult> GetHotelById(int Id, string LanguageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetHotelById(Id, LanguageId);
            if (data == null) return BadRequest();
            return Ok(data);
        }
        
        [HttpGet("image-hotel/{Id}")]
        public async Task<IActionResult> GetImageHotelById(int Id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetListImageHotel(Id);
            if (data == null) return BadRequest();
            return Ok(data);
        }

        [HttpGet("{LanguageId}/hotel-user/{Id}")]
        public async Task<IActionResult> GetHotelByUserId(Guid Id, string LanguageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetHotelByUserId(Id, LanguageId);
            if (data == null) return BadRequest();
            return Ok(data);
        }
        
        [HttpGet("{LanguageId}/hotel-view/{Id}")]
        public async Task<IActionResult> GetHotelByView(int Id, string languageId)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var data = await _hotelAPIService.GetHotelByView(languageId,Id);
            if (data == null) return BadRequest();
            return Ok(data);
        }

        [HttpPut("{Id}"), Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateHotelThumbnail(int Id, [FromForm] CreateImageHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelAPIService.CreateImageThumbnailHotel(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

        [HttpPost("{Id}"), Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateHotelImage(int Id, [FromForm] CreateImageHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelAPIService.CreateImageHotel(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateHotel([FromBody] InfoOwnerRegisterViewModel request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelAPIService.RegisterHotel(request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }


        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteHotelType(int Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelAPIService.DeleteHotelImage(Id);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

        [HttpPut("infohotel/{Id}")]
        public async Task<IActionResult> UpdateHotel(int Id, [FromBody] UpdateHotelRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelAPIService.UpdateHotel(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }


    }
}
