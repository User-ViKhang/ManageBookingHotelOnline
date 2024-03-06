using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Caption).HasColumnType("nvarchar(255)");
            builder.Property(x => x.ImageSize).HasColumnType("decimal");
            builder.Property(x => x.ImageUrl).HasColumnType("varchar(255)");
            builder.Property(x => x.Created).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(x => x.Hotel).WithMany(x => x.Images).HasForeignKey(x => x.Hotel_Id);
        }
    }
}
