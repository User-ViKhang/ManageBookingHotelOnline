using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.HotelTypes
{
    public interface IHotelTypeService
    {
        Task<PageResult<HotelTypeViewModel>> GetHotelType(GetAllHotelTypePagingRequest request);
        Task<List<HotelTypeViewModel>> GetAllHotelType(string languageId);
        Task<HotelTypeViewModel> GetHotelTypeById(string Language_Id, int Id);
        Task<bool> CreateHotelType(CreateHotelTypeRequest request);
        Task<bool> UpdateHotelType(int Id, UpdateHotelTypeRequest request);
        Task<bool> DeleteHotelType(int Id);
    }
}