using Booking_Backend.Data.EF;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Common.Languages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Languages
{
    public class LanguageAPIService : ILanguageAPIService
    {
        private readonly IConfiguration _config;
        private readonly BookingContext _context;

        public LanguageAPIService(IConfiguration configuration, BookingContext appContext)
        {
            _config = configuration;
            _context = appContext;
        }

        public async Task<APIResult<List<LanguageViewModel>>> GetAllLanguage()
        {
            var language = await _context.Languages.Select(x => new LanguageViewModel()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
            return new APIResult_Success<List<LanguageViewModel>>(language);
        }
    }
}