using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class ExtensionConfiguration : IEntityTypeConfiguration<Extension>
    {
        public void Configure(EntityTypeBuilder<Extension> builder)
        {
            builder.ToTable("Extensions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Language).HasColumnType("varchar(5)");

            builder.HasOne(x => x.ExtensionType).WithMany(x => x.Extensions).HasForeignKey(x => x.ExtensionType_Id);
        }
    }
}
