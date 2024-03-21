using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Service.ViewModel;
using Booking_Frontend.AdminApp.Service.ServiceHotel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.ExtensionTypeRoom
{
    public class ExtensionTypeRoomClientService : BaseClientService, IExtensionTypeRoomClientService
    {
        public ExtensionTypeRoomClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateExtensionTypeRoom(CreateExtensionTypeRoomRequest request)
        {
            return await PostAsyncNotFile<CreateExtensionTypeRoomRequest>($"/api/extensiontype", request);
        }

        public async Task<bool> DeleteExtensionTypeRoom(int Id)
        {
            return await DeleteAsync($"/api/extensiontype/{Id}");
        }

        public async Task<List<ExtensionTypeRoomViewModel>> GetAll(string languageId)
        {
            return await GetAsync<List<ExtensionTypeRoomViewModel>>($"/api/extensiontype?languageId={languageId}");
        }

        public async Task<PageResult<ExtensionTypeRoomViewModel>> GetExtensionTypeRoom(GetExtensionTypeRoomRequest request)
        {
            return await GetAsync<PageResult<ExtensionTypeRoomViewModel>>($"/api/extensiontype/paging?language_Id={request.Language_Id}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<bool> UpdateExtensionTypeRoom(int Id, UpdateExtensionTypeRoomRequest request)
        {
            return await PutAsyncNotFile<UpdateExtensionTypeRoomRequest>($"/api/extensiontype/{Id}", request);
        }
    }
}
