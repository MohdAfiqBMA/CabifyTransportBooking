using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Server.Configurations.Entities
{
    public class VehicleSeedConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    VehicleMake = "BMW",
                    VehicleModel = "X1",
                    LicensePlateNumber = "SMU142N",
                    DriverID =  1,
                    CategoryID = 1,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                });
        }
    }
}
