using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeachMe.Models
{
    public class CourseLevel
    {
        public int Id { get; set; }

        [Required][MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public int CreditsFinished { get; set; }

        //override tostring method
        public override string ToString()
        {
            return "Course Level: " + Name;
        }
    }
}