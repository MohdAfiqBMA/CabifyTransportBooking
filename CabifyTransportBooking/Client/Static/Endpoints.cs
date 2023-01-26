using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Client.Static
{
    public class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string PassengersEndpoint = $"{Prefix}/passengers";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string VehiclesEndpoint = $"{Prefix}/vehicles";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string StaffRolesEndpoint = $"{Prefix}/staffroles";
        public static readonly string VehicleCategorysEndpoint = $"{Prefix}/vehiclecategorys";
    }
}
