using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Booking_Backend.Repository.Common
{
    public class APIResult_Success<T> : APIResult<T>
    {
        public APIResult_Success(T resultOject)
        {
            IsSuccessed = true;
            ResultOject = resultOject;
        }
        public APIResult_Success()
        {
            IsSuccessed = true;
        }
    }
}
