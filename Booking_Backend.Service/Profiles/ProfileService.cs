using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Backend.Service.SendEmail;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Profiles
{
    public class ProfileService : IProfileService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;

        public ProfileService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, 
            IConfiguration config)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
        }


        public async Task<APIResult<UserViewModel>> GetProfile(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return new APIResult_Error<UserViewModel>("Người dùng không tồn tại");
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
                Status = user.Status
            };
            return new APIResult_Success<UserViewModel>(result);
        }
        public async Task<APIResult<UserViewModel>> UpdateProfile(string Id, UpdateProfileRequest request)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return new APIResult_Error<UserViewModel>("Người dùng không tồn tại!");
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            user.PhoneNumber = request.PhoneNumber;
            user.DisplayName = request.DisplayName;
            user.Birthday = request.Birthday;
            user.Nation = request.Nation;
            user.Gender = request.Gender;
            user.Address = request.Address;
            user.Dashboard = request.Dashboard;
            user.AvatarUrl = request.AvatarUrl;
            var userModel = new UserViewModel()
            {
                Id = Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                DisplayName = user.DisplayName,
                Birthday = user.Birthday,
                Nation = user.Nation,
                Gender = user.Gender,
                Address = user.Address,
                Dashboard = user.Dashboard,
                AvatarUrl = user.AvatarUrl
            };
            var result = await _userManager.UpdateAsync(user);
            return new APIResult_Success<UserViewModel>(userModel);
        }
        public async Task<APIResult<string>> DeleteProfile(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return new APIResult_Error<string>("Người dùng không tồn tại!");
            var result = await _userManager.DeleteAsync(user);
            return new APIResult_Success<string>("Xóa tài khoản thành công!");
        }
    }
}
