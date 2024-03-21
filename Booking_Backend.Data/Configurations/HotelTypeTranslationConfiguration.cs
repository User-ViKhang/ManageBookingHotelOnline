using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class HotelTypeTranslationConfiguration : IEntityTypeConfiguration<HotelTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<HotelTypeTranslation> builder)
        {
            builder.ToTable("HotelTypeTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Language_Id).HasColumnType("varchar(5)");

            builder.HasOne(x => x.HotelType).WithMany(x => x.HotelTypeTranslations).HasForeignKey(x => x.HotelType_Id).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
