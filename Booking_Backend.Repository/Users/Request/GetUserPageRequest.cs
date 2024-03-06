using Booking_Backend.Repository.Paging.Request;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Users.Request
{
    public class GetUserPageRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
