using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Frontend.APIIntegration.CommentService;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Booking_Frontend.WebApp.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentClientService _comment;

        public CommentController(ICommentClientService comment)
        {
            _comment = comment;
        }

        public IActionResult Create(CreateCommentRequest request)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            _comment.CreateComment(request);
            return new RedirectResult($"/{languageId}/hotel/{request.HotelId}");
        }

        [HttpPost("/comment/update/{Id}")]
        public IActionResult Update(int Id, UpdateCommentRequest request, int HotelId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            _comment.UpdateComment(Id, request);
            return new RedirectResult($"/{languageId}/hotel/{HotelId}");
        }

        [HttpGet("/comment/delete/{Id}/{HotelId}")]
        public IActionResult Delete(int Id, int HotelId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            _comment.DeleteComment(Id);
            return new RedirectResult($"/{languageId}/hotel/{HotelId}");
        }
    }
}
