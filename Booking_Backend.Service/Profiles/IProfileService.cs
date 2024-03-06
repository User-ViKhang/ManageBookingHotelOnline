using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
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
        Task<APIResult<string>> DeleteProfile(string Id);
    }
}
