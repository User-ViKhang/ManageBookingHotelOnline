using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.UserImage.Request;
using Booking_Backend.Repository.UserImage.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Profiles
{
    public interface IProfileService
    {
        Task<APIResult<UserViewModel>> GetProfile(string Id);

        Task<APIResult<UserViewModel>> UpdateProfile(string Id, UpdateProfileRequest request);

        Task<bool> DeleteProfile(string Id);

        Task<APIResult<string>> BlockUser(string Id);

        Task<int> AddImageUser(string userId, CreateUserImageRequest request);

        Task<int> RemoveImageUser(string userId, int imageId);

        Task<int> UpdateImageUser(string userId, int imageId, UpdateUserImageRequest request);

        Task<bool> CreateProfile(RegisterProfileRequest request);

        Task<UserImageViewModel> GetImageById(int imageId);

        Task<UserImageViewModel> GetImageByUserId(string Id);
    }
}