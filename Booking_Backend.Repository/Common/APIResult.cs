using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Common
{
    public class APIResult<T>
    {
        public bool IsSuccessed { get; set; }
        public string Message { get; set; }
        public T ResultOject { get; set; }
    }
}
