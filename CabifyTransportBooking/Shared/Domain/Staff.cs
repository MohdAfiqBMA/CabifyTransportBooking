﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        public string StaffGender { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string StaffFirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string StaffLastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Phone Number given is not a valid number.")]
        public string StaffPhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address given is not a valid email.")]
        [EmailAddress]
        public string StaffEmail { get; set; }
        public int StaffRating { get; set; }
        [Required]
        public int StaffRoleId { get; set; }
        public virtual StaffRole StaffRole { get; set; }

    }
}
