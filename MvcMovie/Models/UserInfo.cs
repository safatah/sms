using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHelper.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string SocialMedia { get; set; }
        public BusinessInfo BusinessInfo { get; set; }
    }

}
