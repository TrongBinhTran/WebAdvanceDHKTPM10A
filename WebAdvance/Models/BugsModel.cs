using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAdvance.Models
{
    public class BugsModel
    {
        // Detection Time
        [Required(ErrorMessage = "Please enter date and time of detection")]
        public string DetectionTime { get; set; }

        // Owner
        [Required(ErrorMessage = "Please enter tester that introduced errors")]
        public string Owner { get; set; }

        // Description
        [Required(ErrorMessage = "Please enter description of the error")]
        public string Description { get; set; }

        // Priority
        [Required(ErrorMessage = "Please enter degree of importance")]
        public string Priority { get; set; }

        // Error Project
        [Required(ErrorMessage = "Please enter project in which the error was detected")]
        public string ErrorProject { get; set; }

        // Status
        [Required(ErrorMessage = "Please enter status of the error")]
        public string Status { get; set; }
    }
}