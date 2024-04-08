using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Frontend.APIIntegration.FormatMoney
{
    public interface IFormatMoney
    {
        string FormatCurrency(decimal value);
    }
}
