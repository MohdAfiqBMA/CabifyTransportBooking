using CabifyTransportBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CabifyTransportBooking.Server.Configurations.Entities
{
    public class PassengerSeedConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasData(
                new Passenger
                {
                    Id = 1,

                    PassengerGender = "Male",

                    PassengerName = "Ben Yeo",

                    PassengerPhone = "98712345",

                    PassengerEmail = "benyeo@gmail.com",

                    PassengerPassword = "Password",
                    
                    PassengerRating = 3,

                    PassengerAddress = "Pasir Ris 51",
    });
        }
    }
}
