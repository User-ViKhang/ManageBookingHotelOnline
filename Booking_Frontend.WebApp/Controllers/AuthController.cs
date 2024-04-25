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
using Booking_Backend.Repository.Accounts.ViewModels;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Repository.SendMail.Request;
using System.Text.Encodings.Web;
using Booking_Frontend.APIIntegration.EmailService;
using Booking_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Asn1.Cmp;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.AspNetCore.Authorization;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Booking_Frontend.WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserAPI _userAPI;
        private readonly IConfiguration _config;
        private readonly IEmailServiceClient _email;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AuthController(IUserAPI userAPI, IConfiguration config, IEmailServiceClient email, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _userAPI = userAPI;
            _config = config;
            _email = email;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //Hiện view
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index", "home");
        }

        // Display view login
        [HttpGet]     
        public async Task<IActionResult> Login()
        {
            HttpContext.Session.Clear();
            return View();
        }
        
        [HttpGet]     
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }

        [HttpPost]     
        public async Task<IActionResult> ForgotPassword(ForgetPasswordViewModel request)
        {
            if(request == null)
                return View();
            var code = await _userAPI.ForgetPassword(request);
            if (!code.IsSuccessed) return RedirectToAction("ForgotPasswordConfirmation", "Auth");
            code.ResultOject = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code.ResultOject));
            var callbackUrl = Url.Action("ResetPassword", "Auth", new { code = code.ResultOject }, Request.Scheme);
            await _email.SendEmail(
                new MailData
                {
                    ReceiverEmail = request.Email,
                    Title = "Reset Password",
                    Body = $"Hãy nhấn vào <a href=\"{HtmlEncoder.Default.Encode(callbackUrl)}\">đây</a> để đặt lại mật khẩu"
                }
              );
            return RedirectToAction("ForgotPasswordConfirmation", "Auth");
        }

        [HttpGet]
        public IActionResult ForgotPasswordConfirmation()
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
            return await Login(loginRequest);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel request)
        {
            var user = await _userAPI.ResetPassword(request);
            if (user.IsSuccessed)
            {
                var loginRequest = new LoginRequest
                {
                    Email = request.Email,
                    Password = request.Password,
                    RemmemberMe = false
                };
                return await Login(loginRequest);
            }
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(ResetPasswordViewModel request, string code = null)
        {
            if (code == null) return BadRequest("Token is invalid");
            request.Token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            return View(request);

        }

        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action("CallBackView", "Auth", values: new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        [Authorize]
        [HttpGet("/use-server-external")]
        public async Task<IActionResult> CallBackView(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Action("Index", "Home");
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if(info == null)
            {
                return RedirectToAction("Login");
            }
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
            var accessToken = info.AuthenticationTokens.FirstOrDefault().Value;
            HttpContext.Session.SetString("Token", accessToken);
            if (result.Succeeded)
            {
                var emailUser = info.Principal.FindFirstValue(ClaimTypes.Email);
                var registedUser = await _userManager.FindByEmailAsync(emailUser);
                return RedirectToAction("index", "homeowner", new { id = registedUser.Id });
            } else if(result.IsLockedOut)
            {
                return RedirectToAction("Logout");
            } else
            {
                var ProviderDisplayName = info.ProviderDisplayName;
                if(info.Principal.HasClaim(c=>c.Type == ClaimTypes.Email))
                {
                    var Input = new RegisterByUser
                    {
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };
                }
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Confirmation(RegisterByUser request, string returnUrl)
        {
            returnUrl = returnUrl ?? Url.Action("Index", "Home");
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {   
                return RedirectToAction("login");
            }
            if(ModelState.IsValid)
            {
                var registedUser = await _userManager.FindByEmailAsync(request.Email);
                string externalEmail = null;
                AppUser externalEmailUser = null;
                if(info.Principal.HasClaim(c=>c.Type== ClaimTypes.Email))
                {
                    externalEmail = info.Principal.FindFirstValue(ClaimTypes.Email);
                }
                if(externalEmail != null)
                {
                    externalEmailUser = await _userManager.FindByEmailAsync(externalEmail);
                }

                if((registedUser != null) && (externalEmailUser != null))
                {
                    if(registedUser.Id == externalEmailUser.Id) {
                        var resultLink = await _userManager.AddLoginAsync(registedUser, info);
                        if(resultLink.Succeeded)
                        {
                            await _signInManager.SignInAsync(externalEmailUser, isPersistent: false);
                            return RedirectToAction("index", "client", new { id = registedUser.Id });
                        }
                    }
                }
                if ((externalEmail== request.Email) && (externalEmailUser == null))
                {
                        var user = new AppUser
                    {
                        UserName = request.Email,
                        Email = request.Email
                    };
                    var result = await _userManager.CreateAsync(user);
                    await _userManager.AddToRoleAsync(user, Roles.Client.ToString());

                    if (result.Succeeded)
                    {
                        var resultLogin = await _userManager.AddLoginAsync(user, info);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
            }
                    return View();
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
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
                IsPersistent = false,
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
