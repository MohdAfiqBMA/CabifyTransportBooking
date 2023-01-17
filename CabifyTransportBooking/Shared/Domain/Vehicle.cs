using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string LicensePlateNumber { get; set; }
        public int DriverID { get; set; }
        public virtual Staff Staff { get; set; }
        public int CategoryID { get; set; }
        public virtual VehicleCategory VehicleCategory { get; set; }
    }
}
