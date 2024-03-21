using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BedRepo.ViewModel;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Service.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Frontend.AdminApp.Service.ExtensionRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.BedService
{
    public class BedClientService : BaseClientService, IBedClientService
    {
        public BedClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<PageResult<BedViewModel>> Get(GetBedRequest request)
        {
            return await GetAsync<PageResult<BedViewModel>>($"/api/bed?language_Id={request.Language_Id}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<bool> Update(int Id, UpdateBedRequest request)
        {
            return await PutAsyncNotFile<UpdateBedRequest>($"/api/bed/{Id}", request);
        }
        public async Task<BedViewModel> GetById(int Id, string languageId)
        {
            return await GetAsync<BedViewModel>($"/api/bed/{languageId}/{Id}");
        }
    }
}
