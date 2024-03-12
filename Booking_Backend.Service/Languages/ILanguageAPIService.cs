using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Common.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Languages
{
    public interface ILanguageAPIService
    {
        Task<APIResult<List<LanguageViewModel>>> GetAllLanguage();
    }
}