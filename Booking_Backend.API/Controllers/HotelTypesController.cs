using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Service.HotelTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelTypesController : ControllerBase
    {
        private readonly IHotelTypeService _hotelTypeService;

        public HotelTypesController(IHotelTypeService hotelTypeService)
        {
            _hotelTypeService = hotelTypeService;
        }

        // Tạo kiểu nghỉ dưỡng theo ngôn ngữ
        [HttpPost, Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateHotelType([FromForm] CreateHotelTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelTypeService.CreateHotelType(request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }


        // Lấy kiểu nghỉ dưỡng chỉ định theo Id và ngôn ngữ
        [HttpGet("{Language_Id}/{Id}"), Consumes("multipart/form-data")]
        public async Task<IActionResult> GetHotelTypeById(string Language_Id, int Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _hotelTypeService.GetHotelTypeById(Language_Id, Id);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        // Lấy kiểu nghỉ dưỡng theo ngôn ngữ
        [HttpGet]
        public async Task<IActionResult> GetHotelType([FromQuery] GetAllHotelTypePagingRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _hotelTypeService.GetHotelType(request);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        // Lấy tất cả kiểu nghỉ dưỡng theo ngôn ngữ
        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllHotelType(string languageId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _hotelTypeService.GetAllHotelType(languageId);
            if (result == null) return BadRequest();
            return Ok(result);
        }
        
        // Cập nhật thông tin kiểu nghỉ dưỡng theo ngôn ngữ
        [HttpPut("{Id}"), Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateHotelType(int Id, [FromForm] UpdateHotelTypeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelTypeService.UpdateHotelType(Id, request);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }

        
        // Xóa thông tin kiểu nghỉ dưỡng theo ngôn ngữ
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteHotelType(int Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var isResult = await _hotelTypeService.DeleteHotelType(Id);
            if (!isResult) return BadRequest();
            return Ok(isResult);
        }
    }
}