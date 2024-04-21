using Booking_Backend.Service.ExternalService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalController : ControllerBase
    {
        private readonly IExternalAPIService _external;

        public ExternalController(IExternalAPIService external)
        {
            _external = external;
        }
    }
}
