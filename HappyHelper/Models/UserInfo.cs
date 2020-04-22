using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Identity;

namespace HappyHelper.Models
{
    public class UserInfo : IdentityUser
    {
        [StringLength(50, MinimumLength = 2)]
        //[Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        //[Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Nickname { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]        
        //public string ContactNumber { get; set; }

        //[DataType(DataType.EmailAddress)]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        //public string ContactEmail { get; set; }

        [StringLength(100)]
        [DataType(DataType.Url)]
        //[RegularExpression(@"((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)")]
        public string SocialMedia { get; set; }


        public BusinessInfo BusinessInfo { get; set; }
    }
}
