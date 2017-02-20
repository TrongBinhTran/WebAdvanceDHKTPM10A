using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAdvance.Models
{
    public class LoginModel
    {
        // User Name
        [Required(ErrorMessage = "Please enter your username")]
        public string UserName { get; set; }

        // Password
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}