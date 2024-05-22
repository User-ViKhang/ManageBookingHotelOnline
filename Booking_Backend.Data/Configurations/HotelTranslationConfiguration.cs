using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class HotelTranslationConfiguration : IEntityTypeConfiguration<HotelTranslation>
    {
        public void Configure(EntityTypeBuilder<HotelTranslation> builder)
        {
            builder.ToTable("HotelTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Area).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Address).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.ShortDescription).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Language_Id).HasColumnType("varchar(5)");

            builder.HasOne(x => x.Hotel).WithMany(x => x.HotelTranslations).HasForeignKey(x => x.Hotel_Id);
        }
    }
}
