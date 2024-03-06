using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Enums;

namespace Booking_Backend.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.Property(x => x.FirstName).HasColumnType("nvarchar(255)");
            builder.Property(x => x.LastName).HasColumnType("nvarchar(255)");
            builder.Property(x => x.DisplayName);
            builder.Property(x => x.Birthday);
            builder.Property(x => x.Address).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Nation).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Gender).HasColumnType("nvarchar(5)");
            builder.Property(x => x.Dashboard);
            builder.Property(x => x.AvatarUrl).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Created).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.Status).HasDefaultValue(StatusUser.Active);
        }
    }
}
