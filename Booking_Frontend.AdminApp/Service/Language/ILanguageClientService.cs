﻿using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Common.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.Language
{
    public interface ILanguageClientService
    {
        Task<APIResult<List<LanguageViewModel>>> GetAllLanguage();
    }
}