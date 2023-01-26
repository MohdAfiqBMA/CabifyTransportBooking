using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string StaffGender { get; set; }
        public string StaffName { get; set; }
        public string StaffPhoneNumber { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPassword { get; set; }
        public int StaffRating { get; set; }
        public int RoleID { get; set; }
        public virtual StaffRole StaffRole { get; set; }

    }
}
