﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CabifyTransportBooking.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
        
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }

        public string PickUpLocation { get; set; }

        public string Destination { get; set; }

        public string PaymentMethod { get; set; }


    }
}