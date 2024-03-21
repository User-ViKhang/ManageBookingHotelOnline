using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.RoomType.ViewModel;
using Booking_Backend.Repository.Service.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.RoomTypeHotel
{
    public interface IRoomTypeAPIService
    {
        Task<PageResult<RoomTypeViewModel>> GetRoomTypes(GetRoomTypeRequest request);
        Task<bool> CreateRoomType(CreateRoomTypeRequest request);
        Task<bool> UpdateRoomTypes(int Id, UpdateRoomTypeRrequest request);
        Task<bool> DeleteRoomType(int Id);

    }
}
