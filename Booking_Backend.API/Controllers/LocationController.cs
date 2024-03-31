using Booking_Backend.Service.LocationServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationAPIService _locAPIService;

        public LocationController(ILocationAPIService locAPIService)
        {
            _locAPIService = locAPIService;
        }

    }
}
