using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_FromAuthentication_MVC.Models
{
    public class Registration
    {
        public string  Name { get; set; }
        public string  Email { get; set; }
        public string  Phone { get; set; }
        public string  Gender { get; set; }
        public string  DOB { get; set; }
        public string  Address { get; set; }
        public string  City { get; set; }
        public int  Zip { get; set; }
        public string  Password { get; set; }
    }
}