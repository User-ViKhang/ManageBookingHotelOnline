using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Service.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public UsersController(IUserService userService, IEmailService emailService) 
        { 
            _userService = userService;
            _emailService = emailService;
        }

        [HttpPost("authenticate"), AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var resultToken = await _userService.Authenticate(request);
            if (string.IsNullOrEmpty(resultToken)) return BadRequest("Email và Password không chính xác!");
            return Ok(new {token = resultToken});
        }

        [HttpPost("register/{roleName}"), AllowAnonymous]
        public async Task<IActionResult> Register(string roleName, [FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var resultToken = await _userService.Register(request, roleName);
            if (!resultToken.IsSuccessed) return BadRequest(resultToken.Message);
            return Ok(resultToken.ResultOject);
        }

        [HttpPost("register-user"), AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterByUser request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var resultToken = await _userService.RegisterByUser(request);
            if (!resultToken.IsSuccessed) return BadRequest(resultToken.Message);
            return Ok(resultToken.ResultOject);
        }

        [HttpPost("forget-password"), AllowAnonymous]
        public async Task<IActionResult> ForgetPassword([FromBody] string email)
        {
            return Ok();
        }

        [HttpPost("email-exist"), AllowAnonymous]
        public async Task<IActionResult> EmailExist([FromBody] string email)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _userService.EmailExist(email);
            return Ok(result);
        }

        //http://localhost/api/users?pagingIndex=1&pagingSize=10&keyword=
        [HttpGet, Authorize]
        public async Task<IActionResult> GetAll([FromQuery] GetUserPageRequest request)
        {
            var user = await _userService.GetAll(request);
            return Ok(user);
        }
        
        //http://localhost/api/users/owner?pagingIndex=1&pagingSize=10&keyword=
        [HttpGet("owner"), Authorize]
        public async Task<IActionResult> GetOwner([FromQuery] GetUserPageRequest request)
        {
            var user = await _userService.GetOwner(request);
            return Ok(user);
        }

        //http://localhost/api/users/client?pagingIndex=1&pagingSize=10&keyword=
        [HttpGet("client"), Authorize]
        public async Task<IActionResult> GetClient([FromQuery] GetUserPageRequest request)
        {
            var user = await _userService.GetClient(request);
            return Ok(user);
        }
        
        [HttpGet("{id}"), Authorize]
        public async Task<IActionResult> GetUserById(string id)
        {
            var user = await _userService.GetUserById(id);
            return Ok(user);
        }
    }
}
    