using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        public string VehicleMake { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]{3}\d{4}[A-Za-z]", ErrorMessage = "License Plate Number doesnot meet requirements")]
        public string LicensePlateNumber { get; set; }
        [Required]
        public int? VehicleOwnerId { get; set; }
        public virtual Staff VehicleOwner { get; set; }
        [Required]
        public int VehicleCategoryId { get; set; }
        public virtual VehicleCategory VehicleCategory { get; set; }
    }
}
