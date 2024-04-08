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
using System.Linq;
using System.Security.Claims;

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



        [HttpPost] //Hiện view
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("login");
        }

        // Display view login
        [HttpGet]     
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return View();
        }
        
        [HttpGet]     
        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterByUser request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _userAPI.RegisterByUser(request);
            if (!result.IsSuccessed) return View();
            var loginRequest = new LoginRequest
            {
                Email = request.Email,
                Password = request.Password,
                RemmemberMe = false
            };
            return RedirectToAction("login", loginRequest);
        }

        // Authentication account  
        [HttpPost]     
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var token = await _userAPI.Authenticate(request);
            if (token == null) return View("login");
            var userPrincipal = _userAPI.ValidatorToken(token);
            if (!userPrincipal.IsInRole(Roles.Client.ToString()) && !userPrincipal.IsInRole(Roles.Owner.ToString())) return View("login");
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(3),
                IsPersistent = false
            };
            HttpContext.Session.SetString("DefaultLanguageId", _config["DefaultLanguageId"]);
            HttpContext.Session.SetString("Token", token);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            var userClaim = userPrincipal.Claims;
            if(userPrincipal.IsInRole(Roles.Client.ToString()))
            {
                var userId = userPrincipal.FindFirst(c => c.Type == "UserId").Value;
                return RedirectToAction("index", "client", new { id = userId });
            } else if (userPrincipal.IsInRole(Roles.Owner.ToString()))
            {
                var userId = userPrincipal.FindFirst(c => c.Type == "UserId").Value;
                return RedirectToAction("index", "homeowner", new { id = userId });
            } else
            {
                return View("login");
            }
        }
    }
}
