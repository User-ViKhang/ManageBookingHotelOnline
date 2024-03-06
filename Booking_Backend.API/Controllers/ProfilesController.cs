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

        [HttpPut("{Id}"), Authorize]
        public async Task<IActionResult> UpdateProfile(string Id, [FromBody] UpdateProfileRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _profileService.UpdateProfile(Id, request);
            if (!result.IsSuccessed) return Ok(result.Message);
            return Ok(result.ResultOject);
        }
        
        [HttpDelete, Authorize]
        public async Task<IActionResult> DeleteProfile(string Id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _profileService.DeleteProfile(Id);
            if (!result.IsSuccessed) return Ok(result.Message);
            return Ok(result.ResultOject);
        }
    }
}
