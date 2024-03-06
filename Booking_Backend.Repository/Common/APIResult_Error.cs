using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Common
{
    public class APIResult_Error<T> : APIResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public APIResult_Error(string message)
        {
            IsSuccessed = false;
            Message = message;
        }
        public APIResult_Error(string[] message)
        {
            IsSuccessed = false;
            ValidationErrors = message;
        }
    }
}
