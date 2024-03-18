using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Backend.Data.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<ServiceHotel>
    {
        public void Configure(EntityTypeBuilder<ServiceHotel> builder)
        {
            builder.ToTable("Services");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Language).HasColumnType("varchar(5)");

        }
    }
}
