using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeachMe.Models;

namespace TeachMe.ViewModels
{
    public class CoursesCoursesLevelViewModel
    {
        public Course Course { get; set; }
        public List<CourseLevel> CourseLevel { get; set; }
    }
}