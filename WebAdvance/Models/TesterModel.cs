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
        [RegularExpression("([a-zA-Z0-9])*", ErrorMessage = "Letters and Numbers only")]
        public string Username { get; set; }

        // Password
        [Required(ErrorMessage = "Please enter your password")]
        [StringLength(1000, MinimumLength = 7)]
        public string Password { get; set; }

        // Fullname
        public string Fullname { get; set; }

        // Email
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        // Phone
        [Required(ErrorMessage = "Please enter your phone")]
        [RegularExpression("([0-9])*", ErrorMessage = "Only Numbers")]
        public string Phone { get; set; }

    }
}