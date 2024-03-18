using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ExtensionTypeRoom
{
    public interface IExtensionTypeRoomAPIService
    {
        Task<PageResult<ExtensionTypeRoomViewModel>> GetExtensionTypeRoom(GetExtensionTypeRoomRequest request);
        Task<List<ExtensionTypeRoomViewModel>> GetAll(string languageId);
        Task<bool> CreateExtensionTypeRoom(CreateExtensionTypeRoomRequest request);
        Task<bool> UpdateExtensionTypeRoom(int Id, UpdateExtensionTypeRoomRequest request);
        Task<bool> DeleteExtensionTypeRoom(int Id);
    }
}
