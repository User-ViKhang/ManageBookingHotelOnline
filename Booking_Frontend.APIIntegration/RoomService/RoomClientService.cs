using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Frontend.APIIntegration.HotelType;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.RoomService
{
    public class RoomClientService : BaseClientService, IRoomClientService
    {
        public RoomClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<APIResult<List<RoomViewModel>>> GetAllRoomByHotelId(int hotelId, string languageId)
        {
            return await GetAsync<APIResult<List<RoomViewModel>>>($"/api/room/{languageId}/hotel-id/{hotelId}");
        }

        public async Task<APIResult<RoomViewModel>> GetRoomByRoomId(int roomId, string languageId)
        {
            return await GetAsync<APIResult<RoomViewModel>>($"/api/room/{languageId}/room-id/{roomId}");
        }

        public async Task<List<Room>> GetRoomsByHotelIdToExtension(int hotelId, string languageId)
        {
            return await GetAsync<List<Room>>($"/api/room/{languageId}/extension-manage/{hotelId}");
        }

        public async Task<bool> UpdateExtension_Room(List<int> Ids, int roomId)
        {
            return await PutAsyncNotFile<List<int>>($"/api/room/room-extension/update/{roomId}", Ids);
        }

        public async Task<bool> UpdateRoom(int roomId, RoomViewModel request)
        {
            return await PutAsyncNotFile<RoomViewModel>($"/api/room/room-id/{roomId}", request);
        }
    }
}
