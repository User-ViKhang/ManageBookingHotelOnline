using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.UserImage.Request;
using Booking_Backend.Repository.UserImage.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Backend.Service.Images;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Profiles
{
    public class ProfileService : IProfileService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        private readonly IImageService _image;
        private readonly BookingContext _context;

        public ProfileService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager,
            IConfiguration config, IImageService image, BookingContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
            _image = image;
            _context = context;
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
            if (request.Avatar != null)
            {
                /*user.UserImages = new List<UserImage>()
                {
                    new UserImage()
                    {
                        Caption = user.UserName,
                        Created = DateTime.Now,
                        ImageSize = request.Avatar.Length,
                        ImageUrl = await _image.SaveFile(request.Avatar),
                        isDefault = true
                    }
                };*/
                var avatar = await _context.UserImages.FirstOrDefaultAsync(x => x.isDefault == true && x.User_Id.ToString() == Id);
                if (avatar != null)
                {
                    avatar.ImageSize = request.Avatar.Length;
                    avatar.ImageUrl = await _image.SaveFile(request.Avatar);
                    avatar.isDefault = true;
                    _context.UserImages.Update(avatar);
                }
            }
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
            await _context.SaveChangesAsync();
            return new APIResult_Success<UserViewModel>(userModel);
        }

        public async Task<APIResult<string>> DeleteProfile(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return new APIResult_Error<string>("Người dùng không tồn tại!");
            var result = await _userManager.DeleteAsync(user);
            return new APIResult_Success<string>("Xóa tài khoản thành công!");
        }

        public async Task<int> AddImageUser(string userId, CreateUserImageRequest request)
        {
            var userImage = new UserImage()
            {
                Caption = request.Caption,
                Created = DateTime.Now,
                isDefault = true,
                User_Id = Guid.Parse(userId),
            };
            if (request.ImageFile != null)
            {
                userImage.ImageUrl = await _image.SaveFile(request.ImageFile);
                userImage.ImageSize = request.ImageFile.Length;
            }
            _context.UserImages.Add(userImage);
            await _context.SaveChangesAsync();
            return userImage.Id;
        }

        public Task<int> RemoveImageUser(string userId, int imageId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateImageUser(string userId, int imageId, UpdateUserImageRequest request)
        {
            var image = await _context.UserImages.FindAsync(imageId);
            if (image == null)
            {
                var userImage = new UserImage()
                {
                    Caption = request.Caption,
                    Created = DateTime.Now,
                    isDefault = true,
                    User_Id = Guid.Parse(userId),
                };
                if (request.ImageFile != null)
                {
                    userImage.ImageUrl = await _image.SaveFile(request.ImageFile);
                    userImage.ImageSize = request.ImageFile.Length;
                }
                _context.UserImages.Add(userImage);
                await _context.SaveChangesAsync();
                return userImage.Id;
            }
            else
            {
                if (request.ImageFile != null)
                {
                    image.ImageUrl = await _image.SaveFile(request.ImageFile);
                    image.ImageSize = request.ImageFile.Length;
                }
                _context.UserImages.Update(image);
                await _context.SaveChangesAsync();
                return image.Id;
            }
        }

        public async Task<UserImageViewModel> GetImageById(int imageId)
        {
            var image = await _context.UserImages.FindAsync(imageId);
            if (image == null) throw new BookingException("Khong tim thay");
            var result = new UserImageViewModel()
            {
                Id = image.Id,
                Caption = image.Caption,
                ImageSize = image.ImageSize,
                ImageUrl = image.ImageUrl,
                Created = image.Created,
                isDefault = image.isDefault
            };
            return result;
        }

        public async Task<bool> CreateProfile(RegisterProfileRequest request)
        {
            if (await _userManager.FindByEmailAsync(request.Email) != null)
                throw new BookingException("Email người dùng đã tồn tại!");
            if (await _userManager.FindByNameAsync(request.UserName) != null)
                throw new BookingException("Username người dùng đã tồn tại!");
            var user = new AppUser()
            {
                FirstName = request.UserName,
                LastName = request.LastName,
                Email = request.Email,
                DisplayName = request.DisplayName,
                Birthday = request.Birthday,
                Nation = request.Nation,
                Gender = request.Gender,
                Address = request.Address,
                Dashboard = request.Dashboard,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };

            if (request.Avatar != null)
            {
                user.UserImages = new List<UserImage>()
                {
                    new UserImage()
                    {
                        Caption = $"avatar-{request.UserName}",
                        ImageSize = request.Avatar.Length,
                        ImageUrl = await _image.SaveFile(request.Avatar),
                        Created = DateTime.Now,
                        isDefault = true
                    }
                };
            }
            string passwordDefault = "Vikhang11112002@";
            if (await _roleManager.RoleExistsAsync(request.RoleName))
            {
                var result = await _userManager.CreateAsync(user, passwordDefault);
                if (!result.Succeeded) throw new BookingException("Gán quyền tài khoản thất bại");
                await _userManager.AddToRoleAsync(user, request.RoleName);
                return true;
            }
            throw new BookingException("Tạo tài khoản thất bại");
        }
    }
}