using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Images
{
    public interface IImageService
    {
        Task<string> SaveFile(IFormFile file);

        Task<string> SaveFile(IFormFile file, string folderName);
    }
}