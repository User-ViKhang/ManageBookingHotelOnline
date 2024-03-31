using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class LocationTranslationConfiguration : IEntityTypeConfiguration<LocationTranslation>
    {
        public void Configure(EntityTypeBuilder<LocationTranslation> builder)
        {
            builder.ToTable("LocationTranslation");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Language_Id).IsRequired();

            builder.HasOne(x=>x.Location).WithMany(x => x.LocationTranslations).HasForeignKey(x=>x.Location_Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
