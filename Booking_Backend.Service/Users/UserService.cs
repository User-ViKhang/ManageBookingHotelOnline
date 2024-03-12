using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.Accounts.ViewModels;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Backend.Service.Profiles;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        private readonly IEmailService _emaiService;
        private readonly BookingContext _context;
        private readonly IProfileService _profile;

        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config, IEmailService emaiService, BookingContext context, IProfileService profile)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _emaiService = emaiService;
            _context = context;
            _profile = profile;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null) return null;
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RemmemberMe, true);
            if (!result.Succeeded) return null;
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, string.Join(",", roles)),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                new Claim("UserId", user.Id.ToString())
            };
            var authSignKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Secret"]));
            var token = new JwtSecurityToken(
                issuer: _config["Tokens:Issuer"],
                audience: _config["Tokens:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: new SigningCredentials(authSignKey, SecurityAlgorithms.HmacSha256));
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<APIResult<string>> Register(RegisterRequest request, string roleName)
        {
            if (await _userManager.FindByEmailAsync(request.Email) != null)
                return new APIResult_Error<string>("Email người dùng đã tồn tại!");
            if (await _userManager.FindByNameAsync(request.UserName) != null)
                return new APIResult_Error<string>("UserName đã tồn tại!");
            var user = new AppUser
            {
                DisplayName = request.DisplayName,
                Nation = request.Nation,
                Email = request.Email,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };
            if (await _roleManager.RoleExistsAsync(roleName))
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                if (!result.Succeeded) return new APIResult_Error<string>("Đăng kí tài khoản thất bại, vui lòng kiểm tra lại.");
                await _userManager.AddToRoleAsync(user, roleName);
                return new APIResult_Success<string>("Tạo tài khoản thành công!");
            }
            return new APIResult_Error<string>("Gán quyền tài khoản thất bại!");
        }

        public async Task<APIResult<string>> ForgetPassword(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) return new APIResult_Error<string>("Email chưa được đăng kí tài khoản!");
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return new APIResult_Success<string>(token);
        }

        public async Task<APIResult<string>> EmailExist(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) return new APIResult_Error<string>("Email không tồn tại!");
            return new APIResult_Success<string>("Email hợp lệ");
        }

        public async Task<APIResult<ClaimsPrincipal>> ValidatorToken(string token)
        {
            var Secret = _config["Tokens:Secret"];
            var Issuer = _config["Tokens:Issuer"];
            var Audience = _config["Tokens:Audience"];
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(Secret);

                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidIssuer = Issuer,
                    ValidAudience = Audience, // Thêm Audience vào phần cấu hình xác thực token
                    ClockSkew = TimeSpan.Zero
                };

                SecurityToken validatedToken;
                var claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
                return new APIResult_Success<ClaimsPrincipal>(claimsPrincipal);
            }
            catch (Exception)
            {
                return new APIResult_Error<ClaimsPrincipal>("Token không hợp lệ");
            }
        }

        public async Task<APIResult<PageResult<UserViewModel>>> GetAll(GetUserPageRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new UserViewModel()
            {
                Id = x.Id.ToString(),
                UserName = x.UserName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DisplayName = x.DisplayName,
                Birthday = x.Birthday,
                Nation = x.Nation,
                Gender = x.Gender,
                Address = x.Address,
                Dashboard = x.Dashboard,
                AvatarUrl = x.AvatarUrl,
                Created = x.Created,
                Status = x.Status
            }).ToListAsync();
            var PagedResult = new PageResult<UserViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return new APIResult_Success<PageResult<UserViewModel>>(PagedResult);
        }

        public async Task<APIResult<PageResult<UserViewModel>>> GetOwner(GetUserPageRequest request)
        {
            var query = from roleTable in _context.Roles
                        where roleTable.Name == "Owner"
                        join userroleTable in _context.UserRoles on roleTable.Id equals userroleTable.RoleId
                        join userTable in _context.Users on userroleTable.UserId equals userTable.Id
                        select new { userTable };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.userTable.UserName.Contains(request.Keyword) || x.userTable.PhoneNumber.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new UserViewModel()
            {
                Id = x.userTable.Id.ToString(),
                UserName = x.userTable.UserName,
                Email = x.userTable.Email,
                PhoneNumber = x.userTable.PhoneNumber,
                FirstName = x.userTable.FirstName,
                LastName = x.userTable.LastName,
                DisplayName = x.userTable.DisplayName,
                Birthday = x.userTable.Birthday,
                Nation = x.userTable.Nation,
                Gender = x.userTable.Gender,
                Address = x.userTable.Address,
                Dashboard = x.userTable.Dashboard,
                AvatarUrl = x.userTable.AvatarUrl,
                Created = x.userTable.Created,
                Status = x.userTable.Status
            }).ToListAsync();
            var PagedResult = new PageResult<UserViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return new APIResult_Success<PageResult<UserViewModel>>(PagedResult);
        }

        public async Task<APIResult<PageResult<UserViewModel>>> GetClient(GetUserPageRequest request)
        {
            var query = from roleTable in _context.Roles
                        where roleTable.Name == "Client"
                        join userroleTable in _context.UserRoles on roleTable.Id equals userroleTable.RoleId
                        join userTable in _context.Users on userroleTable.UserId equals userTable.Id
                        select new { userTable };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.userTable.UserName.Contains(request.Keyword) || x.userTable.PhoneNumber.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new UserViewModel()
            {
                Id = x.userTable.Id.ToString(),
                UserName = x.userTable.UserName,
                Email = x.userTable.Email,
                PhoneNumber = x.userTable.PhoneNumber,
                FirstName = x.userTable.FirstName,
                LastName = x.userTable.LastName,
                DisplayName = x.userTable.DisplayName,
                Birthday = x.userTable.Birthday,
                Nation = x.userTable.Nation,
                Gender = x.userTable.Gender,
                Address = x.userTable.Address,
                Dashboard = x.userTable.Dashboard,
                AvatarUrl = x.userTable.AvatarUrl,
                Created = x.userTable.Created,
                Status = x.userTable.Status
            }).ToListAsync();
            var PagedResult = new PageResult<UserViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return new APIResult_Success<PageResult<UserViewModel>>(PagedResult);
        }

        public async Task<APIResult<UserViewModel>> GetUserById(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return new APIResult_Error<UserViewModel>("Tài khoản không tồn tại!");
            var result = new UserViewModel()
            {
                Id = user.Id.ToString(),
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DisplayName = user.DisplayName,
                Birthday = user.Birthday,
                Nation = user.Nation,
                Gender = user.Gender,
                Address = user.Address,
                Dashboard = user.Dashboard,
                AvatarUrl = user.AvatarUrl,
                Created = user.Created,
                Status = user.Status,
                Avatar = await _profile.GetImageByUserId(Id)
            };
            return new APIResult_Success<UserViewModel>(result);
        }
    }
}