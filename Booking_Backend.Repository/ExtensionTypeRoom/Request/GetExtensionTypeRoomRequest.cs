using Booking_Backend.Repository.Paging.Request;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.ExtensionTypeRoom.Request
{
    public class GetExtensionTypeRoomRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string Language_Id { get; set; }
    }
}
