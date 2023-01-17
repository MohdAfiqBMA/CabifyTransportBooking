using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportVehicleCategory.Server.Configurations.Entities
{
    public class VehicleCategorySeedConfiguration : IEntityTypeConfiguration<VehicleCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VehicleCategory> builder)
        {
            builder.HasData(
                   new VehicleCategory
                   {
                       Id = 1,
                       Name = "Standard Fare",
                       Capacity = 5,
                       Price = 12.50,
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       CreatedBy = "System",
                       UpdatedBy = "System"
                   }
                   );
        }
    }
}
