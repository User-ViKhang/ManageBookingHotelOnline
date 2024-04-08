using Microsoft.AspNetCore.Mvc;

namespace Booking_Frontend.WebApp.Controllers
{
    public class PageController : Controller
    {
        public IActionResult BookingSuccess()
        {
            return View();
        }
    }
}
