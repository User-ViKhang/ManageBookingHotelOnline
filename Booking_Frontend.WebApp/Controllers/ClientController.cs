using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Frontend.WebApp.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
