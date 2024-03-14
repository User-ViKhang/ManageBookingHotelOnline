﻿using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.HotelType
{
    public interface IHotelTypeClientService
    {
        Task<PageResult<HotelTypeViewModel>> GetHotelType(GetAllHotelTypePagingRequest request);

        Task<bool> UpdateHotelType(int Id, UpdateHotelTypeRequest request);

        Task<bool> DeleteHotelType(int Id);
    }
}