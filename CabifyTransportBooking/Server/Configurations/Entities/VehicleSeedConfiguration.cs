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
                    VehicleMake = "BMW",
                    VehicleModel = "X1",
                    LicensePlateNumber = "SMU142N",
                    DriverID =  1,
                    CategoryID = 0,
             
    });
        }
    }
}
