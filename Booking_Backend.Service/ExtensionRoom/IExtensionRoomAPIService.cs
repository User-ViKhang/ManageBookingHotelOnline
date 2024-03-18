using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ExtensionRoom
{
    public interface IExtensionRoomAPIService
    {
        Task<PageResult<ExtensionRoomViewModel>> GetExtensionRoom(GetExtensionRoomRequest request);
        Task<bool> CreateExtensionRoom(CreateExtensionRoomRequest request);
        Task<bool> UpdateExtensionRoom(int Id, UpdateExtensionRoomRequest request);
        Task<bool> DeleteExtensionRoom(int Id);
    }
}
