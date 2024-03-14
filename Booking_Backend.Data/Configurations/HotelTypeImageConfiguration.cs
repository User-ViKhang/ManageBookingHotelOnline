using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class HotelTypeImageConfiguration : IEntityTypeConfiguration<HotelTypeImage>
    {
        public void Configure(EntityTypeBuilder<HotelTypeImage> builder)
        {
            builder.ToTable("HotelTypeImages");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Caption).HasColumnType("nvarchar(255)");
            builder.Property(x => x.ImageSize).HasColumnType("decimal");
            builder.Property(x => x.ImageUrl).HasColumnType("varchar(255)");
            builder.Property(x => x.Created).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.isDefault).HasDefaultValue(true);

            builder.HasOne(x => x.HotelType).WithMany(x => x.HotelTypeImages).HasForeignKey(x => x.HotelType_Id);
        }
    }
}