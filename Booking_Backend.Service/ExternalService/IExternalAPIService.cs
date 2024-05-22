using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ExternalService
{
    public interface IExternalAPIService
    {
        Task<AuthenticationProperties> ConfigExternalAuthProp(string provider, string redirectUrl);
    }
}
