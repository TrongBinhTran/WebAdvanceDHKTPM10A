using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAdvance.Models
{
    public class ProjectsModel
    {
        // Name
        [Required(ErrorMessage = "Please enter your name of project")]
        public string Name { get; set; }

        // Description
        public string Description { get; set; }
    }
}