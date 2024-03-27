using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.RoomType.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Frontend.APIIntegration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.RoomType
{
    public class RoomTypeClientService : BaseClientService, IRoomTypeClientService
    {
        public RoomTypeClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateRoomType(CreateRoomTypeRequest request)
        {
            return await PostAsyncNotFile<CreateRoomTypeRequest>($"/api/roomtype", request);
        }

        public async Task<bool> DeleteRoomType(int Id)
        {
            return await DeleteAsync($"/api/roomtype/{Id}");
        }

        public async Task<PageResult<RoomTypeViewModel>> GetRoomType(GetRoomTypeRequest request)
        {
            return await GetAsync<PageResult<RoomTypeViewModel>>($"/api/roomtype?languageId={request.LanguageId}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<bool> UpdateRoomType(int Id, UpdateRoomTypeRrequest request)
        {
            return await PutAsyncNotFile<UpdateRoomTypeRrequest>($"/api/roomtype/{Id}", request);
        }
    }
}
