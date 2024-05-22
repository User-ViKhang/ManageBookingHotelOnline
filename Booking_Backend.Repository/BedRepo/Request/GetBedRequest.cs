using Booking_Backend.Repository.Paging.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BedRepo.Request
{
    public class GetBedRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string Language_Id { get; set; }
    }
}
