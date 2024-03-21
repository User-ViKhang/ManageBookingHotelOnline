using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ExtensionTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language_Id { get; set; }

        public Extension Extension { get; set; }
        public int Extension_Id { get; set; }
    }
}
