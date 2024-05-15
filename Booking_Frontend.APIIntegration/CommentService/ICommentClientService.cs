using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Backend.Repository.CommentRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.CommentService
{
    public interface ICommentClientService
    {
        Task<List<CommentViewModel>> GetAllCommentByHotelId(int hotelId);
        Task<bool> CreateComment(CreateCommentRequest request);
        Task<bool> UpdateComment(int Id, UpdateCommentRequest request);
        Task<bool> DeleteComment(int Id);
        Task<bool> LikeComment(LikeCommentRequest request);
        Task<List<Comment_User>> GetAllCommentLikeByUserId(Guid UserId);

    }
}
