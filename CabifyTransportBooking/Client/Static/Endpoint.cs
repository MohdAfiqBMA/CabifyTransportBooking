using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Client.Static
{
    public class Endpoint
    {
        private static readonly string Prefix = "api";

        public static readonly string PassengerEndpoint = $"{Prefix}/passenger";
        public static readonly string StaffEndpoint = $"{Prefix}/staff";
        public static readonly string VehicleEndpoint = $"{Prefix}/vehicle";
        public static readonly string BookingEndpoint = $"{Prefix}/booking";
    }
}
