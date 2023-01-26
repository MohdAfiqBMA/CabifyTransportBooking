using CabifyTransportBooking.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Passenger> Passengers { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<StaffRole> StaffRoles { get; }
        IGenericRepository<VehicleCategory> VehicleCategorys { get; }
    }
}