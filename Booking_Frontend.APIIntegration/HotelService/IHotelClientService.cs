using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.HotelService
{
    public interface IHotelClientService
    {
        Task<PageResult<HotelViewModel>> GetHotelByLocation(GetHotelByLocationRequest request);
        Task<HotelDetailViewModel> GetHotelById(int Id, string LanguageId);
    }
}
