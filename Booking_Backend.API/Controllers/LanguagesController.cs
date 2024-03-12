using Booking_Backend.Service.Languages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageAPIService _languageAPIService;

        public LanguagesController(ILanguageAPIService languageAPIService)
        {
            _languageAPIService = languageAPIService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguage()
        {
            var language = await _languageAPIService.GetAllLanguage();
            return Ok(language);
        }
    }
}