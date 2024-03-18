using Booking_Backend.Repository.Paging.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.Request
{
    public class GetHotelPageRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string Language { get; set; }
    }
}
