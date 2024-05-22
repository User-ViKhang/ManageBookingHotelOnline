using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.Profile
{
    public interface IProfileClientService
    {
        Task<bool> CreateProfile(RegisterProfileRequest request);

        Task<APIResult<UserViewModel>> UpdateProfile(string Id, UpdateProfileRequest request);

        Task<bool> DeleteProfile(string Id);
    }
}