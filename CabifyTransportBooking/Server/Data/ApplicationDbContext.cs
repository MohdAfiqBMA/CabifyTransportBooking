using CabifyTransportBooking.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CabifyTransportBooking.Shared.Domain;
using CabifyTransportBooking.Server.Configurations.Entities;

namespace CabifyTransportBooking.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<VehicleCategory> VehicleCategorys { get; set; }
        public DbSet<StaffRole> StaffRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new PassengerSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
        }
    }
}
