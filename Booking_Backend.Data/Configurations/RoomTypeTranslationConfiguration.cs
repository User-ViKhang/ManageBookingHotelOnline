using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class RoomTypeTranslationConfiguration : IEntityTypeConfiguration<RoomTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<RoomTypeTranslation> builder)
        {
            builder.ToTable("RoomTypeTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Language_Id).HasColumnType("varchar(5)");

            builder.HasOne(x=>x.RoomType).WithMany(x=>x.RoomTypeTranslations).HasForeignKey(x => x.RoomType_Id);
        }
    }
}
