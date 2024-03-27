using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Frontend.WebApp.Controllers
{
    [Authorize(Roles = "Owner")]
    public class OwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
