using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.Profile
{
    public class ProfileClientService : IProfileClientService
    {
        private readonly IHttpClientFactory _httpClientfactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;

        public ProfileClientService(IHttpClientFactory httpClientfactory, IHttpContextAccessor httpContextAccessor, IConfiguration config)
        {
            _httpClientfactory = httpClientfactory;
            _httpContextAccessor = httpContextAccessor;
            _config = config;
        }

        public async Task<bool> CreateProfile(RegisterProfileRequest request)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);

            var requestContent = new MultipartFormDataContent();
            if (request.Avatar != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.Avatar.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.Avatar.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "avatar", request.Avatar.FileName);
            }

            requestContent.Add(new StringContent(request.UserName), "userName");
            requestContent.Add(new StringContent(request.Email), "email");
            requestContent.Add(new StringContent(request.PhoneNumber), "phoneNumber");
            requestContent.Add(new StringContent(request.FirstName), "firstName");
            requestContent.Add(new StringContent(request.LastName), "lastName");
            requestContent.Add(new StringContent(request.DisplayName), "displayName");
            requestContent.Add(new StringContent(request.Birthday.ToString()), "birthday");
            requestContent.Add(new StringContent(request.Nation), "nation");
            requestContent.Add(new StringContent(request.Gender), "gender");
            requestContent.Add(new StringContent(request.Address), "address");
            requestContent.Add(new StringContent(request.Dashboard.ToString()), "dashboard");
            requestContent.Add(new StringContent("Vikhang11112002@"), "password");
            requestContent.Add(new StringContent(request.RoleName), "roleName");

            var response = await client.PostAsync($"/api/profiles", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProfile(string Id)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.DeleteAsync($"/api/profiles/{Id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<APIResult<UserViewModel>> UpdateProfile(string Id, UpdateProfileRequest request)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var dth = request.Birthday;
            var requestContent = new MultipartFormDataContent();
            if (request.Avatar != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.Avatar.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.Avatar.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "avatar", request.Avatar.FileName);
            }

            requestContent.Add(new StringContent(request.UserName), "userName");
            requestContent.Add(new StringContent(request.PhoneNumber), "phoneNumber");
            requestContent.Add(new StringContent(request.FirstName), "firstName");
            requestContent.Add(new StringContent(request.LastName), "lastName");
            requestContent.Add(new StringContent(request.DisplayName), "displayName");
            requestContent.Add(new StringContent(request.Birthday.ToString("MM/dd/yyyy HH:mm:ss")), "birthday");
            requestContent.Add(new StringContent(request.Nation), "nation");
            requestContent.Add(new StringContent(request.Gender), "gender");
            requestContent.Add(new StringContent(request.Address), "address");
            requestContent.Add(new StringContent(request.Dashboard.ToString()), "dashboard");

            var response = await client.PutAsync($"/api/profiles/{Id}", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<APIResult_Success<UserViewModel>>(body);
            return JsonConvert.DeserializeObject<APIResult_Error<UserViewModel>>("Cập nhật thông tin người dùng thất bại");
        }
    }
}