using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Frontend.APIIntegration.FormatMoney
{
    public class FormatMoney : IFormatMoney
    {
        public string FormatCurrency(decimal value)
        {
            return value.ToString("C");
        }
    }
}
