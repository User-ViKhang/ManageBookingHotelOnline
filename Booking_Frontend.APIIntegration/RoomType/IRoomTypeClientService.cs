using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.RoomType.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.RoomType
{
    public interface IRoomTypeClientService
    {
        Task<PageResult<RoomTypeViewModel>> GetRoomType(GetRoomTypeRequest request);
        Task<bool> UpdateRoomType(int Id, UpdateRoomTypeRrequest request);
        Task<bool> CreateRoomType(CreateRoomTypeRequest request);
        Task<bool> DeleteRoomType(int Id);
    }
}
