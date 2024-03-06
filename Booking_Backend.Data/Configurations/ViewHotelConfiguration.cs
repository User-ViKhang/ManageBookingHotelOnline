using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class ViewHotelConfiguration : IEntityTypeConfiguration<ViewHotel>
    {
        public void Configure(EntityTypeBuilder<ViewHotel> builder)
        {
            builder.ToTable("ViewHotels");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.ImageUrl).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Language).HasColumnType("varchar(5)");
        }
    }
}
