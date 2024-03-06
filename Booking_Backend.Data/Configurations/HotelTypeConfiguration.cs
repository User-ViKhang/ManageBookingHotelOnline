using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class HotelTypeConfiguration : IEntityTypeConfiguration<HotelType>
    {
        public void Configure(EntityTypeBuilder<HotelType> builder)
        {
            builder.ToTable("HotelTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.ImageUrl).HasColumnType("varchar(255)");
            builder.Property(x => x.Language).HasColumnType("varchar(5)");

        }
    }
}
