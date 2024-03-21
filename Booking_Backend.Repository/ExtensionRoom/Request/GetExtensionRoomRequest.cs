using Booking_Backend.Repository.Paging.Request;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.ExtensionRoom.Request
{
    public class GetExtensionRoomRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string LanguageId { get; set; }
        public int ExtensionTypeId { get; set; }
    }
}
