using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Server.Configurations.Entities
{
    public class BookingSeedConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                   new Booking
                   {
                       Id = 1,
                       PickUpLocation = "Bedok",
                       Destination = "Tampines",
                       PaymentMethod = "Credit Card",
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       CreatedBy = "System",
                       UpdatedBy = "System"
                   }
                   );

        }
    }
}
