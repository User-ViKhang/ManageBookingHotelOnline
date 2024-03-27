using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.User
{
    public interface IUserAPI
    {
        Task<string> Authenticate(LoginRequest request);
        ClaimsPrincipal ValidatorToken(string jwt);
        Task<APIResult<PageResult<UserViewModel>>> GetAll(GetUserPageRequest request);
        Task<APIResult<PageResult<UserViewModel>>> GetOwner(GetUserPageRequest request);
        Task<APIResult<PageResult<UserViewModel>>> GetClient(GetUserPageRequest request);
        Task<APIResult<UserViewModel>> GetUserById(string Id);
        Task<APIResult<UserViewModel>> UpdateUser(string Id, UserViewModel request);
        Task<APIResult<UserViewModel>> Create(string roleName, RegisterRequest request);

    }
}
