using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class StaffRole:BaseDomainModel
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string RoleType { get; set; }
    }
}
