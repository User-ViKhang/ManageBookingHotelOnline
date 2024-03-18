using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Frontend.AdminApp.Service.ExtensionTypeRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.ExtensionRoom
{
    public class ExtensionRoomClientService : BaseClientService, IExtensionRoomClientService
    {
        public ExtensionRoomClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateExtensionRoom(CreateExtensionRoomRequest request)
        {
            return await PostAsyncNotFile<CreateExtensionRoomRequest>($"/api/extensionroom", request);
        }

        public async Task<bool> DeleteExtensionRoom(int Id)
        {
            return await DeleteAsync($"/api/extensionroom/{Id}");
        }

        public async Task<PageResult<ExtensionRoomViewModel>> GetExtensionRoom(GetExtensionRoomRequest request)
        {
            return await GetAsync<PageResult<ExtensionRoomViewModel>>($"/api/extensionroom?languageId={request.LanguageId}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&extensiontypeId={request.ExtensionTypeId}&keyword={request.Keyword}");
        }

        public async Task<bool> UpdateExtensionRoom(int Id, UpdateExtensionRoomRequest request)
        {
            return await PutAsyncNotFile<UpdateExtensionRoomRequest>($"/api/extensionroom/{Id}", request);
        }
    }
}
