using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class ExtensionTypeConfiguration : IEntityTypeConfiguration<ExtensionType>
    {
        public void Configure(EntityTypeBuilder<ExtensionType> builder)
        {
            builder.ToTable("ExtensionTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

        }
    }
}
