using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.ExtensionRoom
{
    public interface IExtensionRoomClientService
    {
        Task<PageResult<ExtensionRoomViewModel>> GetExtensionRoom(GetExtensionRoomRequest request);
        Task<bool> CreateExtensionRoom(CreateExtensionRoomRequest request);
        Task<bool> UpdateExtensionRoom(int Id, UpdateExtensionRoomRequest request);
        Task<bool> DeleteExtensionRoom(int Id);

    }
}
