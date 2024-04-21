using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Bill;
using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Backend.Repository.CommentRepo.ViewModel;
using Booking_Frontend.APIIntegration.BookingService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.CommentService
{
    public class CommentClientService : BaseClientService, ICommentClientService
    {
        public CommentClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateComment(CreateCommentRequest request)
        {
            return await PostAsyncNotFile<CreateCommentRequest>($"/api/comment", request);
        }

        public async Task<bool> DeleteComment(int Id)
        {
            return await DeleteAsync($"/api/comment/{Id}");
        }

        public async Task<List<CommentViewModel>> GetAllCommentByHotelId(int hotelId)
        {
            return await GetAsync<List<CommentViewModel>>($"/api/comment/{hotelId}");
        }

        public async Task<bool> UpdateComment(int Id, UpdateCommentRequest request)
        {
            return await PostAsyncNotFile<UpdateCommentRequest>($"/api/comment/{Id}", request);
        }
    }
}
