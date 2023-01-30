using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Passenger : BaseDomainModel
    {
        public string PassengerGender { get; set; }
        public string PassengerName { get; set; }
        public string PassengerPhone { get; set; }
        public string PassengerEmail { get; set; }
        public int PassengerRating { get; set; }
        public string  PassengerAddress { get; set; }

    }
}
