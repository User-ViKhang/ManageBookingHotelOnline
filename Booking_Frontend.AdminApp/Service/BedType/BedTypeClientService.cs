using Booking_Backend.Repository.BedTypeRepo.Request;
using Booking_Backend.Repository.BedTypeRepo.ViewModel;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.AdminApp.Service.HotelType;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.BedType
{
    public class BedTypeClientService : BaseClientService, IBedTypeClientService
    {
        public BedTypeClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateBedType(CreateBedTypeRequest request)
        {
            return await PostAsyncNotFile<CreateBedTypeRequest>($"/api/bed", request);
        }

        public async Task<bool> DeleteBedType(int Id)
        {
            return await DeleteAsync($"/api/bed/{Id}");
        }

        public async Task<PageResult<BedTypeViewModel>> GetBedType(GetBedTypeRequest request)
        {
            return await GetAsync<PageResult<BedTypeViewModel>>($"/api/bed?languageId={request.LanguageId}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<BedTypeViewModel> GetBedTypeById(int Id)
        {
            return await GetAsync<BedTypeViewModel>($"/api/bed/{Id}");
        }

        public async Task<bool> UpdateBedType(int Id, UpdateBedTypeRequest request)
        {
            return await PutAsyncNotFile<UpdateBedTypeRequest>($"/api/bed/{Id}", request);
        }
    }
}
