using Booking_Backend.Repository.UserImage.Request;
using Booking_Backend.Service.Profiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Dynamic;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserImagesController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public UserImagesController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpPost("/{userId}/image")]
        public async Task<IActionResult> Create(string userId, [FromForm] CreateUserImageRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var imageId = await _profileService.AddImageUser(userId, request);
            if (imageId == 0) return BadRequest();
            var image = await _profileService.GetImageById(imageId);
            return CreatedAtAction(nameof(GetImageById), new { imageId = imageId }, image);
        }

        [HttpPut("/{userId}/image/{imageId}")]
        public async Task<IActionResult> Update(string userId, int imageId, [FromForm] UpdateUserImageRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var _imageId = await _profileService.UpdateImageUser(userId, imageId, request);
            if (_imageId == 0) return BadRequest();
            var image = await _profileService.GetImageById(_imageId);
            return CreatedAtAction(nameof(GetImageById), new { imageId = imageId }, image);
        }

        [HttpGet("{imageId}")]
        public async Task<IActionResult> GetImageById(int imageId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var image = await _profileService.GetImageById(imageId);
            if (image == null) return BadRequest();
            return Ok(image);
        }
    }
}