using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class ExtensionTranslationConfiguration : IEntityTypeConfiguration<ExtensionTranslation>
    {
        public void Configure(EntityTypeBuilder<ExtensionTranslation> builder)
        {
            builder.ToTable("ExtensionTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Language_Id).HasColumnType("varchar(5)");

            builder.HasOne(x => x.Extension).WithMany(x => x.ExtensionTranslations).HasForeignKey(x => x.Extension_Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
