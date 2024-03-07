using Booking_Backend.Repository.Users.Request;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.Profile
{
    public interface IProfileClientService
    {
        Task<bool> CreateProfile(RegisterProfileRequest request);
    }
}