using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomRepo.Request;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Booking_Frontend.APIIntegration.HotelService
{
    public class HotelClientService : BaseClientService, IHotelClientService
    {
        public HotelClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateImageHotel(int Id, CreateImageHotelRequest request)
        {
            var requestContent = new MultipartFormDataContent();
            if (request.Image != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.Image.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.Image.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "Image", request.Image.FileName);
            }

            var response = await PostAsync($"/api/hotel/{Id}", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public async Task<bool> CreateImageThumbnailHotel(int Id, CreateImageHotelRequest request)
        {
            var requestContent = new MultipartFormDataContent();
            if (request.Image != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.Image.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.Image.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "image", request.Image.FileName);
            }

            var response = await PutAsync($"/api/hotel/{Id}", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public async Task<bool> DeleteHotelImage(int Id)
        {
            return await DeleteAsync($"/api/hotel/{Id}");
        }

        public async Task<HotelDetailViewModel> GetHotelById(int Id, string LanguageId)
        {
            return await GetAsync<HotelDetailViewModel>($"/api/hotel/{LanguageId}/{Id}");
        }

        public async Task<PageResult<HotelViewModel>> GetHotelByLocation(GetHotelByLocationRequest request)
        {
            return await GetAsync<PageResult<HotelViewModel>>($"/api/Hotel?LanguageId={request.LanguageId}&LocationName={request.LocationName}&DateCheckIn={request.DateCheckIn.ToString("MM-dd-yyyy")}&DateCheckOut={request.DateCheckOut.ToString("MM-dd-yyyy")}&TotalPeople={request.TotalPeople}&PageIndex={request.PageIndex}&PageSize={request.PageSize}");
                                                                                              //https://localhost:5001/api/Hotel?LanguageId=vi-VN&LocationName=Da%20Lat&DateCheckIn=11-11-2024&DateCheckOut=11-11-2024&TotalPeople=2&PageIndex=1&PageSize=10
        }

        public async Task<HotelOwnerViewModel> GetHotelByUserId(Guid Id, string LanguageId)
        {
            return await GetAsync<HotelOwnerViewModel>($"/api/hotel/{LanguageId}/hotel-user/{Id}");
        }

        public async Task<List<Image>> GetListImageHotel(int Id)
        {
            return await GetAsync<List<Image>>($"/api/hotel/image-hotel/{Id}");
        }

        public async Task<bool> RegisterHotel(InfoOwnerRegisterViewModel request)
        {
            return await PostAsyncNotFile<InfoOwnerRegisterViewModel>("/api/hotel", request);
        }

        public async Task<bool> UpdateHotel(int Id, UpdateHotelRequest request)
        {
            return await PutAsyncNotFile<UpdateHotelRequest>($"/api/hotel/infohotel/{Id}", request);
        }
    }
}
