using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Server.Configurations.Entities
{
    public class StaffRoleSeedConfiguration : IEntityTypeConfiguration<StaffRole>
    {
        public void Configure(EntityTypeBuilder<StaffRole> builder)
        {
            builder.HasData(
                new StaffRole
                {
                    Id = 1,
                    RoleName = "Admin",
                    RoleDescription = "Support employees by assigning tasks",
                    RoleType = "Admin",
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new StaffRole
                {
                    Id = 2,
                    RoleName = "Driver",
                    RoleDescription = "Drive passengers to the intended destination",
                    RoleType = "Driver",
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                }
                );
        }
    }
}
