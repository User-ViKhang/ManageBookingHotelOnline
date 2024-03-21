using Booking_Backend.Data.EF;
using Booking_Backend.Repository.Common.Languages;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Users.ViewModel;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http.Headers;
using System;

namespace Booking_Frontend.AdminApp.Service.HotelType
{
    public class HotelTypeClientService : BaseClientService, IHotelTypeClientService
    {
        public HotelTypeClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateHotelType(CreateHotelTypeRequest request)
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

            requestContent.Add(new StringContent(request.NameVI), "namevi");
            requestContent.Add(new StringContent(request.NameEN), "nameen");

            var response = await PostAsync($"/api/hoteltypes", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public async Task<bool> DeleteHotelType(int Id)
        {
            return await DeleteAsync($"/api/hoteltypes/{Id}");
        }

        public async Task<PageResult<HotelTypeViewModel>> GetHotelType(GetAllHotelTypePagingRequest request)
        {
            return await GetAsync<PageResult<HotelTypeViewModel>>($"/api/hoteltypes?languageId={request.LanguageId}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<bool> UpdateHotelType(int Id, UpdateHotelTypeRequest request)
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

            requestContent.Add(new StringContent(request.Name), "name");
            requestContent.Add(new StringContent(request.Language_Id), "languageId");

            var response = await PutAsync($"/api/hoteltypes/{Id}", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}