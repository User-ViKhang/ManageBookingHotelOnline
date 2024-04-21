using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomRepo.Request;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Rooms
{
    public interface IRoomAPIService
    {
        Task<bool> ChangeStatusRoom(int roomId, StatusRoom status);
        Task<APIResult<List<RoomViewModel>>> GetAllRoomByIdHotel(int hotelId, string languageId);
        Task<APIResult<RoomViewModel>> GetRoomByRoomId(int roomId, string languageId);
        Task<bool> UpdateRoom(int roomId, RoomViewModel request);
        Task<List<Room>> GetRoomsByHotelIdToExtension(int hotelId, string languageId);
        Task<bool> UpdateRoom_Extension(List<int> IdsExtension, int roomId);
        Task<bool> CreateRoom(CreateRoomRequest request);
    }
}
