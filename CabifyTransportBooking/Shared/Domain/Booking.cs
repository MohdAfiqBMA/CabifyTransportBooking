using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public string PickUpLocation { get; set; }
        public string Destination { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public int AdminID? { get; set; }
        public virtual Staff Admin { get; set; }

        public int DriverID { get; set; }
        public virtual Staff Driver { get; set; }

        public int PassengerID { get; set; }
        public virtual Passenger Passenger { get; set; }

        public int CategoryID { get; set; }
        public virtual VehicleCategory Category { get; set; }


    }
}
