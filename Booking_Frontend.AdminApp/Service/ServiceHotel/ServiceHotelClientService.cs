using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Service.ViewModel;
using Booking_Frontend.AdminApp.Service.HotelType;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.ServiceHotel
{
    public class ServiceHotelClientService : BaseClientService, IServiceHotelClientService
    {
        public ServiceHotelClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateServiceHotel(CreateServiceHotelRequest request)
        {
            return await PostAsyncNotFile<CreateServiceHotelRequest>($"/api/servicehotel", request);
        }

        public async Task<bool> DeleteServiceHotel(int Id)
        {
            return await DeleteAsync($"/api/servicehotel/{Id}");
        }

        public async Task<PageResult<ServiceHotelViewModel>> GetServiceHotel(GetServiceHotelRequest request)
        {
            return await GetAsync<PageResult<ServiceHotelViewModel>>($"/api/servicehotel?languageId={request.LanguageId}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }
        
        public async Task<ServiceHotelViewModel> GetServiceHotelById(string languageId, int Id)
        {
            return await GetAsync<ServiceHotelViewModel>($"/api/servicehotel/{languageId}/{Id}");
        }

        public async Task<bool> UpdateServiceHotel(int Id, UpdateServiceHotelRequest request)
        {
            return await PutAsyncNotFile<UpdateServiceHotelRequest>($"/api/servicehotel/{Id}", request);
        }
    }
}