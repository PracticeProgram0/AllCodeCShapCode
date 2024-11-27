using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using System.Linq;
using System.Web;
using MVC_Valid;

namespace MVC_Valid.Models
{
    public class valid
    {
        [Required(ErrorMessage = "Enter Your First Name")]
        public string fname { get; set; }
        [Required(ErrorMessage = "Enter Your Last Name")]

        public string lname { get; set; }

        public string email { get; set; }
        
        public string password { get; set; }
        [Required(ErrorMessage = "Enter Your password")]
        [Compare("password",ErrorMessage = "Password or Confirm Password Not Match ")]
        public string cpassword { get; set; }
        [Phone ]
        public string phone { get; set; }
        [StringLength(10,ErrorMessage = "Enter Your phone")]
        public string address { get; set; }
        [DateCheck]
        public string Date { get; set; }

    }
}