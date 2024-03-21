using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Extension
    {
        public int Id { get; set; }

        public ExtensionType ExtensionType { get; set; }
        public int ExtensionType_Id { get; set; }

        public List<Room_Extension> Room_Extensions { get; set; }
        public List<ExtensionTranslation> ExtensionTranslations { get; set; }

    }
}
