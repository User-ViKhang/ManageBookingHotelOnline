using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class BedTranslationConfiguration : IEntityTypeConfiguration<BedTranslation>
    {
        public void Configure(EntityTypeBuilder<BedTranslation> builder)
        {
            builder.ToTable("BedTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");

            builder.HasOne(x => x.Bed).WithMany(x => x.BedTranslations).HasForeignKey(x => x.Bed_Id).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
