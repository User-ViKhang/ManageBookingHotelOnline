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
            if (request.Thumbnail != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.Thumbnail.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.Thumbnail.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnail", request.Thumbnail.FileName);
            }

            requestContent.Add(new StringContent(request.Name), "name");
            if (!string.IsNullOrEmpty(request.ImageUrl))
                requestContent.Add(new StringContent(request.ImageUrl), "imageUrl");
            else
                requestContent.Add(new StringContent("default-img"), "imageUrl");
            requestContent.Add(new StringContent(request.LanguageId), "languageId");

            var response = await PutAsync($"/api/hoteltypes/{Id}", requestContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}