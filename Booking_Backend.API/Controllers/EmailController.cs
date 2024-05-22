using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _mailService;

        public EmailController(IEmailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail([FromBody] MailData data)
        {
            var result = await _mailService.SendEmailAsync(data);
            return Ok(result);
        }

        [HttpPost("SendEMail")]
        public async Task<IActionResult> SendEMail([FromBody] MailData data)
        {
            var result = await _mailService.SendEmail(data);
            return Ok(result);
        }
    }
}
