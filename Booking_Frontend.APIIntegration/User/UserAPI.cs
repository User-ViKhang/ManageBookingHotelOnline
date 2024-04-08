using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.User
{
    public class UserAPI : IUserAPI
    {
        private readonly IHttpClientFactory _httpClientfactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;
        public UserAPI(IHttpClientFactory httpClientFactory, IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientfactory = httpClientFactory;
            _config = config;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var respone = await client.PostAsync("/api/users/authenticate", httpContent);
            if(!respone.IsSuccessStatusCode) return null;
            var jsonToken = await respone.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonToken); // jsonString là chuỗi JSON như bạn đã cung cấp
            var token = jsonObject["token"].ToString();
            return token;
        }

        public ClaimsPrincipal ValidatorToken(string jwt)
        {
            string token = jwt.Replace("{\"token\":\"", "").Replace("\"}", "");
            //Kiểm tra tính hợp lệ token
            IdentityModelEventSource.ShowPII = true;
            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();
            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _config["Tokens:Audience"];
            validationParameters.ValidIssuer = _config["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Secret"]));
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out validatedToken);
            return principal;
        }

        public async Task<APIResult<PageResult<UserViewModel>>> GetAll(GetUserPageRequest request)
        {
            var client = _httpClientfactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync($"/api/users?" +
                $"pageIndex={request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<APIResult_Success<PageResult<UserViewModel>>>(body); // chuyen thanh json
            return users;
        }

        public async Task<APIResult<PageResult<UserViewModel>>> GetOwner(GetUserPageRequest request)
        {
            var client = _httpClientfactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync($"/api/users/owner?" +
                $"pageIndex={request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<APIResult_Success<PageResult<UserViewModel>>>(body); // chuyen thanh json
            return users;
        }

        public async Task<APIResult<PageResult<UserViewModel>>> GetClient(GetUserPageRequest request)
        {
            var client = _httpClientfactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync($"/api/users/client?" +
                $"pageIndex={request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<APIResult_Success<PageResult<UserViewModel>>>(body); // chuyen thanh json
            return users;
        }

        public async Task<APIResult<UserViewModel>> GetUserById(string Id)
        {
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync($"/api/users/{Id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<APIResult_Success<UserViewModel>>(body);
            return JsonConvert.DeserializeObject<APIResult_Error<UserViewModel>>(body);
        }

        public async Task<APIResult<UserViewModel>> UpdateUser(string Id, UserViewModel request)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"/api/profiles/{Id}", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) 
                return JsonConvert.DeserializeObject<APIResult_Success<UserViewModel>>(body);
            return JsonConvert.DeserializeObject<APIResult_Error<UserViewModel>>("Faild");
        }

        public async Task<APIResult<UserViewModel>> Create(string roleName, RegisterRequest request)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"/api/users/register/{roleName}", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<APIResult_Success<UserViewModel>>(body);
            return JsonConvert.DeserializeObject<APIResult_Error<UserViewModel>>("Faild");
        }

        public async Task<APIResult<string>> RegisterByUser(RegisterByUser request)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"/api/users/register-user", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<APIResult_Success<string>>(body);
            return JsonConvert.DeserializeObject<APIResult_Error<string>>("Faild");
        }
    }
}
