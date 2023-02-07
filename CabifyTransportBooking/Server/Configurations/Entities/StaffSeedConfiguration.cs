using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffFirstName = "Jon",
                    StaffLastName = "Snow",
                    StaffGender = "Male",
                    StaffEmail = "john123@gmail.com",
                    StaffPhoneNumber = "98765432",
                    StaffRating = 4,
                    StaffRoleId = 2,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Staff
                {
                    Id = 2,
                    StaffFirstName = "Ellie",
                    StaffLastName = "Williams",
                    StaffGender = "Female",
                    StaffEmail = "ellie123@gmail.com",
                    StaffPhoneNumber = "98765423",
                    StaffRating = 4,
                    StaffRoleId = 1,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                });
        }
    }
}
