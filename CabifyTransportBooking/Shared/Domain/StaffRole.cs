using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class StaffRole : BaseDomainModel
    {
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string RoleDescription { get; set; }
        [Required]
        public string RoleType { get; set; }
    }
}
