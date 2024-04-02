using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _mailService;

        public EmailController(IEmailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail([FromBody] MailData data)
        {
            var result = await _mailService.SendEmailAsync(data);
            return Ok(result);
        }
    }
}
