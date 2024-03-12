using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Service.Profiles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfilesController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("{Id}"), Authorize]
        public async Task<IActionResult> GetProfile(string Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _profileService.GetProfile(Id);
            if (!result.IsSuccessed) return Ok(result.Message);
            return Ok(result.ResultOject);
        }

        [HttpPut("{Id}"), Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateProfile(string Id, [FromForm] UpdateProfileRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _profileService.UpdateProfile(Id, request);
            if (!result.IsSuccessed) return Ok(result.Message);
            return Ok(result.ResultOject);
        }

        [HttpDelete("{Id}"), Authorize]
        public async Task<IActionResult> DeleteProfile(string Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _profileService.DeleteProfile(Id);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpPost, Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateProfile([FromForm] RegisterProfileRequest request)
        {
            if (!ModelState.IsValid) return BadRequest("Dữ liệu yêu cầu sai");
            var isResult = await _profileService.CreateProfile(request);
            if (!isResult) return BadRequest("Logic xử lý sai");
            return Ok("Tạo tài khoản thành công");
        }
    }
}