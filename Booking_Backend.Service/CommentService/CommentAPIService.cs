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

namespace Booking_Backend.Service.CommentService
{
    public class CommentAPIService : ICommentAPIService
    {
        private readonly BookingContext _context;

        public CommentAPIService(BookingContext context)
        {
            _context = context;
        }

        /*public async Task<PageResult<CommentViewModel>> GetCommentBy_HotelId(GetCommentRequest request)
        {
            var query = from comment in _context.Comments
                        join hotel in _context.Hotels on comment.Hotel_Id equals hotel.Id
                        join user in _context.Users on comment.User_Id equals user.Id
                        where hotel.Id == request.Hotel_Id
                        select new {comment, hotel, user};

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new CommentViewModel()
            {
                Id = x.comment.Id,
                Content = x.comment.Content,
                Created = DateTime.Now,
                Hotel = new HotelTranslation()
                {
                    Id = x.hotel.Id,
                    Name = x.hotel.Name,
                    Language = x.hotel.Language,
                },
                User = new AppUser()
                {
                    Id = x.user.Id,
                    UserName = x.user.UserName
                }
                
            }).ToListAsync();
            var PagedResult = new PageResult<CommentViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }*/
    }
}
