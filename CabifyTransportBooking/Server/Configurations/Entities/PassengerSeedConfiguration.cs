using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Server.Configurations.Entities
{
    public class PassengerSeedConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Passenger> builder)
        {
            builder.HasData(
                    new Passenger
                    {
                        Id = 1,
                        PassengerName = "Johnny Adam",
                        PassengerPhone = "96541234",
                        PassengerEmail = "JohnAdam@gmail.com",
                        PassengerPassword = "123456",
                        PassengerRating = 3,
                        PassengerAddress = "Tampinese Ave 1",
                        PassengerGender = "Male",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );
        }
    }
}
