using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HappyHelper.Models
{
    public class BusinessInfo
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Please enter a valid business/shop name")]
        public string BusinessName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        [Required(ErrorMessage = "Please enter a valid phone number")]
        public string BusinessNumber { get; set; }

        [RegularExpression(@"^[a - zA - Z0 - 9\s.\-] +$", ErrorMessage = "Please enter a valid address")]
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter a valid city name")]
        public string City { get; set; }


        [Required(ErrorMessage = "Please choose a state")]
        public string State { get; set; }

        [RegularExpression(@"^((\d{5}-\d{4})|(\d{5})|([A - Z]\d[A - Z]\s\d[A - Z]\d))$", ErrorMessage = "Please enter a valid zip code")]
        [Required]
        public int ZipCode { get; set; }

    }
}
