using Booking_Backend.Repository.Users.Request;
using Booking_Frontend.APIIntegration.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Backend.Repository.Common;
using Microsoft.AspNetCore.Identity;
using Booking_Backend.Data.Entities;
using Booking_Frontend.APIIntegration.Profile;
using Microsoft.Extensions.Configuration;
using Booking_Backend.Data.Enums;

namespace Booking_Frontend.AdminApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAPI _userAPI;
        private readonly IProfileClientService _profileClient;
        private readonly IConfiguration _config;

        public UserController(IUserAPI userAPI, IProfileClientService profileClient, IConfiguration config)
        {
            _userAPI = userAPI;
            _profileClient = profileClient;
            _config = config;
        }

        public async Task<IActionResult> Index(string key, int pageIndex = 1, int pageSize = 10)
        {
            var session = HttpContext.Session.GetString("Token");
            var request = new GetUserPageRequest()
            {
                //BearerToken = session,
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userAPI.GetAll(request);
            return View(data);
        }

        public async Task<IActionResult> Owner(string key, int pageIndex = 1, int pageSize = 10)
        {
            var session = HttpContext.Session.GetString("Token");
            var request = new GetUserPageRequest()
            {
                //BearerToken = session,
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userAPI.GetOwner(request);
            return View(data);
        }

        public async Task<IActionResult> Client(string key, int pageIndex = 1, int pageSize = 10)
        {
            var session = HttpContext.Session.GetString("Token");
            var request = new GetUserPageRequest()
            {
                //BearerToken = session,
                Keyword = key,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userAPI.GetClient(request);
                return View(data);
        }

        //Hiện trang và thông tin cập nhật
        [HttpGet("user/update/{Id}")]
        public async Task<IActionResult> Update(string Id)
        {
            var user = await _userAPI.GetUserById(Id);
            try
            {
                if (!user.IsSuccessed) return RedirectToAction("index", "user");
                return View(user);
            }
            catch
            {
                return RedirectToAction("logout", "user");
            }
        }

        //Xử lí logic cập nhật
        [HttpPost, Consumes("multipart/form-data")]
        public async Task<IActionResult> Update(string Id, UpdateProfileRequest request)
        {
            var user = await _profileClient.UpdateProfile(Id, request);
            try
            {
                if (!user.IsSuccessed) return RedirectToAction("update", "user");
                return RedirectToAction("index", "user");
            }
            catch
            {
                return RedirectToAction("logout", "user");
            }
        }

        [HttpGet] //Hiện view
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return View();
        }

        [HttpPost] //Hiện view
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("login", "user");
        }

        [HttpPost] //Xử lí logic đăng nhập
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid) return View(ModelState);
            var token = await _userAPI.Authenticate(request);
            var userPrincipal = _userAPI.ValidatorToken(token);
            if (!userPrincipal.IsInRole(Roles.Administrators.ToString())) return View("login");
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1),
                IsPersistent = false
            };
            HttpContext.Session.SetString("DefaultLanguageId", _config["DefaultLanguageId"]);
            HttpContext.Session.SetString("Token", token);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            return RedirectToAction("index", "home");
        }

        //Hiện View
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        //Xóa người dùng
        [HttpGet("user/delete/{Id}")]
        public async Task<IActionResult> Delete(string Id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var isResult = await _profileClient.DeleteProfile(Id);
            if (!isResult) return BadRequest();
            return NoContent();
        }

        //Hiện View FindUser
        [HttpGet]
        public async Task<IActionResult> FindUser()
        {
            return View();
        }

        //Xử lí logic Create
        [HttpPost, Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] RegisterProfileRequest request)
        {
            if (!ModelState.IsValid) return View(request);
            var isResult = await _profileClient.CreateProfile(request);
            if (isResult)
            {
                return RedirectToAction("index", "user");
            }
            ModelState.AddModelError("", "Thêm mới người dùng thất bại");
            return View(request);
        }
    }
}