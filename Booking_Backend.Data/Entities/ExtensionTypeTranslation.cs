using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ExtensionTypeTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }

        public ExtensionType ExtensionType { get; set; }
        public int ExtensionType_Id { get; set; }
    }
}
