using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Booking_Backend.Data.EF
{
    public class BookingContextFactory : IDesignTimeDbContextFactory<BookingContext>
    {
        public BookingContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configurationRoot.GetConnectionString("Booking_DB");
            var optionsBuilder = new DbContextOptionsBuilder<BookingContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new BookingContext(optionsBuilder.Options);
        }
    }
}
