﻿using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Http;
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

        Task<bool> CreateImageThumbnailHotel(int Id, CreateImageHotelRequest request);
        Task<bool> UpdateHotel(int Id, UpdateHotelRequest request);
        Task<bool> CreateImageHotel(int Id, CreateImageHotelRequest request);
        Task<List<Image>> GetListImageHotel(int Id);
        Task<bool> DeleteHotelImage(int Id);

        Task<List<HotelViewViewModel>> GetHotelByView(string languageId, int viewId);

        Task<bool> RegisterHotel(InfoOwnerRegisterViewModel request);
        Task<bool> ChangeDes(int HotelId, string Des, string LanguageId);

    }
}
