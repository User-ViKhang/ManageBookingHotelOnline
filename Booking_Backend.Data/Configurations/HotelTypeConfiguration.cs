using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class HotelTypeConfiguration : IEntityTypeConfiguration<HotelType>
    {
        public void Configure(EntityTypeBuilder<HotelType> builder)
        {
            builder.ToTable("HotelTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.HotelTypeImage).WithOne(x => x.HotelType).HasForeignKey<HotelType>(x => x.HotelTypeImage_Id);
        }
    }
}
