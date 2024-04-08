using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.RoomService
{
    public interface IRoomClientService
    {
        Task<APIResult<List<RoomViewModel>>> GetAllRoomByHotelId(int hotelId, string languageId);
        Task<APIResult<RoomViewModel>> GetRoomByRoomId(int roomId, string languageId);
        Task<bool> UpdateRoom(int roomId, RoomViewModel request);
        Task<List<Room>> GetRoomsByHotelIdToExtension(int hotelId, string languageId);
        Task<bool> UpdateExtension_Room(List<int> Ids, int roomId);



    }
}
