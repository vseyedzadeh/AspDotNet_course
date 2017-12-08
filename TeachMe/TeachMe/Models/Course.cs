using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TeachMe.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required][MaxLength(255)]
        public string Title { get; set; }

        [Required][MaxLength(10)]
        public string Code { get; set; }

        [Required][Range(1,4)]
        public int NumberOfCredits { get; set; }

        [Required][Range(1,25)]
        public int MaximumNumberOfStudents { get; set; }

        public string ProvideBy { get; set; }

        [Required]
        public CourseLevel CourseLevel { get; set; }
        public int CourseLevelId { get; set; }

        //override tostring method
        public override string ToString()
        {
            return "Course name: " + Title;
        }
    }
}