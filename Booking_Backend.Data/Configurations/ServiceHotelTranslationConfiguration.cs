using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Backend.Data.Configurations
{
    public class ServiceHotelTranslationConfiguration : IEntityTypeConfiguration<ServiceHotelTranslation>
    {
        public void Configure(EntityTypeBuilder<ServiceHotelTranslation> builder)
        {
            builder.ToTable("ServiceHotelTranslations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Language_Id).HasColumnType("varchar(5)");

            builder.HasOne(x => x.ServiceHotel).WithMany(x => x.ServiceHotelTranslations).HasForeignKey(x => x.ServiceHotel_Id).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
