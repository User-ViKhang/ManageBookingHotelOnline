using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Backend.Repository.CommentRepo.ViewModel;
using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.CommentService
{
    public interface ICommentAPIService
    {
        Task<List<CommentViewModel>> GetAllCommentByHotelId(int hotelId);
        Task<bool> CreateComment(CreateCommentRequest request);
        Task<bool> UpdateComment(int Id, UpdateCommentRequest request);
        Task<bool> DeleteComment(int Id);

    }
}
