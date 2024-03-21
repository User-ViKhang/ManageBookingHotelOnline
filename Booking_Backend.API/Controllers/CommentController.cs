using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Backend.Service.CommentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentAPIService _comment;

        public CommentController(ICommentAPIService comment)
        {
            _comment = comment;
        }

        /*[HttpGet]
        public async Task<IActionResult> GetCommentBy_HotelId([FromQuery] GetCommentRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.GetCommentBy_HotelId(request);
            if (result == null) return BadRequest();
            return Ok(result);
        }*/
    }
}
