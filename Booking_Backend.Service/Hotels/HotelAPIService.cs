using Booking_Backend.Data.EF;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Service.Files;
using Booking_Backend.Service.Images;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Hotels
{
    public class HotelAPIService : IHotelAPIService
    {
        private readonly BookingContext _context;
        private readonly IImageService _image;
        private readonly IStorageService _storage;

        public HotelAPIService(BookingContext context, IImageService image, IStorageService storage)
        {
            _context = context;
            _image = image;
            _storage = storage;
        }

        public Task<PageResult<HotelViewModel>> GetHotel(GetHotelPageRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
