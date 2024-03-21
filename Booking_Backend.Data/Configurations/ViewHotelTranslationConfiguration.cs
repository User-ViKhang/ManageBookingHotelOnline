using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class ViewHotelTranslationConfiguration : IEntityTypeConfiguration<ViewHotelTranslation>
    {
        public void Configure(EntityTypeBuilder<ViewHotelTranslation> builder)
        {
            builder.ToTable("ViewHotelTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Language_Id).HasColumnType("varchar(5)");

            builder.HasOne(x => x.ViewHotel).WithMany(x => x.ViewHotelTranslations).HasForeignKey(x => x.ViewHotel_Id);
        }
    }
}
