using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Backend.Service.CommentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("{hotelId}")]
        public async Task<IActionResult> GetAllCommentByHotelId(int hotelId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.GetAllCommentByHotelId(hotelId);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpGet("like/{UserId}")]
        public async Task<IActionResult> GetAllCommentByUserId(Guid UserId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.GetAllCommentLikeByUserId(UserId);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.CreateComment(request);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpPost("{Id}")]
        public async Task<IActionResult> UpdateComment(int Id, UpdateCommentRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.UpdateComment(Id, request);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikeComment(LikeCommentRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.LikeComment(request);
            if (!result) return BadRequest();
            return Ok(result);
        }
        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteComment(int Id) 
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _comment.DeleteComment(Id);
            if (!result) return BadRequest();
            return Ok(result);
        }
    }
}
