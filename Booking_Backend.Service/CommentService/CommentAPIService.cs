using Booking_Backend.Data.EF;
using Booking_Backend.Repository.CommentRepo.Request;
using Booking_Backend.Repository.CommentRepo.ViewModel;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Booking_Backend.Data.Entities;
using System.Diagnostics.Eventing.Reader;

namespace Booking_Backend.Service.CommentService
{
    public class CommentAPIService : ICommentAPIService
    {
        private readonly BookingContext _context;

        public CommentAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateComment(CreateCommentRequest request)
        {
            var createComment = new Comment
            {
                Content = request.Content,
                Created = DateTime.Now,
                Hotel_Id = request.HotelId,
                Hotel = await _context.Hotels.FindAsync(request.HotelId),
                User = await _context.Users.FindAsync(Guid.Parse(request.UserId)),
                User_Id = Guid.Parse(request.UserId)
            };
            _context.Comments.Add(createComment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteComment(int Id)
        {
            var comment = await _context.Comments.FindAsync(Id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<CommentViewModel>> GetAllCommentByHotelId(int hotelId)
        {
            var commnet = await _context.Comments
                        .Include(cmt => cmt.User)
                        .Where(cmt => cmt.Hotel_Id == hotelId)
                        .Select(cmt => new CommentViewModel
                        {
                            Id = cmt.Id,
                            Content = cmt.Content,
                            Created = cmt.Created,
                            User = new AppUser
                            {
                                Id = cmt.User.Id,
                                UserName = cmt.User.UserName,
                                UserImages = cmt.User.UserImages,
                                DisplayName = cmt.User.DisplayName
                            },
                            HotelId = hotelId,
                            CountComment = cmt.CountComment
                        }).ToListAsync();
            return commnet;
        }

        public async Task<List<Comment_User>> GetAllCommentLikeByUserId(Guid UserId)
        {
            var commentlikes = await _context.Comment_Users.Where(x=>x.User.Id == UserId).ToListAsync();
            return commentlikes;
        }

        public async Task<bool> LikeComment(LikeCommentRequest request)
        {
            var comment_user = await _context.Comment_Users.FirstOrDefaultAsync(x => x.Comment_Id == request.CommentId && x.User_Id == request.UserId);
            var commentItem = await _context.Comments.FindAsync(request.CommentId);

            if (comment_user == null)
            {
                var result = new Comment_User
                {
                    Comment_Id = request.CommentId,
                    User_Id = request.UserId
                };
                await _context.Comment_Users.AddAsync(result);
                await _context.SaveChangesAsync();
                commentItem.CountComment = commentItem.CountComment + 1;
                _context.Comments.Update(commentItem);
                await _context.SaveChangesAsync();
                return true;
            }
            _context.Remove(comment_user);
            await _context.SaveChangesAsync();
            commentItem.CountComment = commentItem.CountComment - 1;
            _context.Comments.Update(commentItem);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateComment(int Id, UpdateCommentRequest request)
        {
            var comment = await _context.Comments.FindAsync(Id);
            comment.Content = request.Content;
            comment.Created = DateTime.Now;
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
