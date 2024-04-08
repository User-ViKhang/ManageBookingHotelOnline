using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Frontend.WebApp.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        public IActionResult Index(string Id)
        {
            HttpContext.Session.SetString("UserIdClient", Id);
            return RedirectToAction("index", "home");
        }
        

    }
}
