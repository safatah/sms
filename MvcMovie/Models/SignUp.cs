using HappyHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHelper.Models
{
    public class SignUp : UserInfo
    { 
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
