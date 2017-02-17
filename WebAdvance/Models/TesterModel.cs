using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAdvance.Models
{
    public class TesterModel
    {
        // Username
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }

        // Password
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        // Fullname
        public string Fullname { get; set; }

        // Email
        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        // Phone
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

    }
}