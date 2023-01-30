using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class VehicleCategory : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category does not meet length requirements")]
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public float Price { get; set; }

    }
}
