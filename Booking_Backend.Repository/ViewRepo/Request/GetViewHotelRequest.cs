using Booking_Backend.Repository.Paging.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.ViewRepo.Request
{
    public class GetViewHotelRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string LanguageId { get; set; }
    }
}
