using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CabifyTransportBooking.Shared.Domain
{
    public class Passenger : BaseDomainModel
    {
        [Required]
        public string PassengerGender { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string PassengerName { get; set; }
        [Required]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Phone Number given is not a valid number.")]
        public string PassengerPhone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string PassengerEmail { get; set; }
        [Required]
        public int PassengerRating { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address does not meet length requirements")]
        public string  PassengerAddress { get; set; }

    }
}
