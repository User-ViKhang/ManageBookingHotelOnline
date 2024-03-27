using Booking_Backend.Repository.Users.Request;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using Booking_Frontend.APIIntegration.Profile;
using Booking_Frontend.APIIntegration.User;
using Microsoft.Extensions.Configuration;
using Booking_Backend.Data.Enums;

namespace Booking_Frontend.WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserAPI _userAPI;
        private readonly IConfiguration _config;

        public AuthController(IUserAPI userAPI, IConfiguration config)
        {
            _userAPI = userAPI;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Display view login
        [HttpGet]     
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return View();
        }

        // Authentication account  
        [HttpPost]     
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var token = await _userAPI.Authenticate(request);
            var userPrincipal = _userAPI.ValidatorToken(token);
            if (!userPrincipal.IsInRole(Roles.Client.ToString()) && !userPrincipal.IsInRole(Roles.Owner.ToString())) return View("login");
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1),
                IsPersistent = false
            };
            HttpContext.Session.SetString("DefaultLanguageId", _config["DefaultLanguageId"]);
            HttpContext.Session.SetString("Token", token);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            if(userPrincipal.IsInRole(Roles.Client.ToString()))
            {
                return RedirectToAction("index", "client");
            } else if (userPrincipal.IsInRole(Roles.Client.ToString()))
            {
                return RedirectToAction("index", "owner");
            } else
            {
                return View("login");
            }
        }
    }
}
