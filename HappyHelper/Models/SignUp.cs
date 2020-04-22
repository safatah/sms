using HappyHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HappyHelper.Models
{
    public class SignUp : UserInfo
    {
        //[DataType(DataType.EmailAddress)]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        //[Required(ErrorMessage = "Please enter a valid email address")]
        //public string ProfileEmail { get; set; }

        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$")]
        //[StringLength(20, MinimumLength = 8)]
        //[Required(ErrorMessage = "Please enter a valid password. Password must be between 8-20 characters")]
        //public string Password { get; set; }
    }

}
