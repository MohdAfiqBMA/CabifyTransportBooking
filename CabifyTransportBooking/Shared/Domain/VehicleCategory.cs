using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class VehicleCategory : BaseDomainModel
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public float Price { get; set; }
    }
}
