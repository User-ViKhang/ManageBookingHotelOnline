using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index(string Id)
        {
            HttpContext.Session.SetString("UserId_Client", Id);
            return RedirectToAction("index", "home");
        }
        

    }
}
