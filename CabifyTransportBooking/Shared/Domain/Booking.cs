using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = " Pick Up Location does not meet length requirements")]
        public string PickUpLocation { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = " Destination does not meet length requirements")]
        public string Destination { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public int? AdminId { get; set; }
        [NotMapped]
        public virtual Staff Admin { get; set; }
        [Required]
        public int? DriverId { get; set; }
        public virtual Staff Driver { get; set; }
        [Required]
        public int? PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        public virtual VehicleCategory Category { get; set; }

    }
}
