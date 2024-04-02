using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Hotels
{
    public interface IHotelAPIService
    {
        Task<PageResult<HotelViewModel>> GetHotelByLocation(GetHotelByLocationRequest request);
        Task<HotelDetailViewModel> GetHotelById(int Id, string LanguageId);
        Task<HotelOwnerViewModel> GetHotelByUserId(Guid Id, string LanguageId);
    }
}
