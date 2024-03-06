using Booking_Backend.Repository.Accounts.ViewModels;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Users
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<APIResult<string>> Register(RegisterRequest request, string roleName);
        Task<APIResult<string>> ForgetPassword(string email);
        Task<APIResult<string>> EmailExist(string email);
        Task<APIResult<ClaimsPrincipal>> ValidatorToken(string token);
        Task<APIResult<PageResult<UserViewModel>>> GetAll(GetUserPageRequest request);
        Task<APIResult<PageResult<UserViewModel>>> GetOwner(GetUserPageRequest request);
        Task<APIResult<PageResult<UserViewModel>>> GetClient(GetUserPageRequest request);
        Task<APIResult<UserViewModel>> GetUserById(string Id);

    }
}
