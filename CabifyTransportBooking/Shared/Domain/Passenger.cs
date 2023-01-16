using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Passenger : BaseDomainModel
    {
        public string PassengerGender { get; set; }

        public string PassengerName { get; set; }

        public string PassengerPhoneNumber { get; set; }

        public string PassengerEmail { get; set; }

        public string PassengerPassword { get; set; }

        public int PassengerRating { get; set; }

        public string PassengerAddress { get; set; }
    }
}