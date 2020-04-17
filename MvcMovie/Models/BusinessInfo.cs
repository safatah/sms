using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHelper.Models
{
    public class BusinessInfo
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string BusinessNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }
}
