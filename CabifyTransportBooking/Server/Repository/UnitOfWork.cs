using CabifyTransportBooking.Server.Data;
using CabifyTransportBooking.Server.IRepository;
using CabifyTransportBooking.Server.Models;
using CabifyTransportBooking.Server.Repository;
using CabifyTransportBooking.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Passenger> _passengers;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<StaffRole> _staffroles;
        private IGenericRepository<VehicleCategory> _vehiclecategorys;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Booking> Bookings
            => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Passenger> Passengers
            => _passengers ??= new GenericRepository<Passenger>(_context);
        public IGenericRepository<Vehicle> Vehicles
            => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<StaffRole> StaffRoles
            => _staffroles ??= new GenericRepository<StaffRole>(_context);
        public IGenericRepository<VehicleCategory> VehicleCategorys
            => _vehiclecategorys ??= new GenericRepository<VehicleCategory>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}