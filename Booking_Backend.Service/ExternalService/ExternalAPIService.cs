using Booking_Backend.Data.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ExternalService
{
    public class ExternalAPIService : IExternalAPIService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;

        public ExternalAPIService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }

        public async Task<AuthenticationProperties> ConfigExternalAuthProp(string provider, string redirectUrl)
        {
            var properties =  _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return properties;
        }
    }
}
