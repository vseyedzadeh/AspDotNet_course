using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TeachMe.Models;
using TeachMe.ViewModels;

namespace TeachMe.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            
            var course = _context.Courses.Include(c => c.CourseLevel).ToList();
            return View(course);
        }

        public ActionResult Detail(int courseId)
        {
            var selectedCourse = _context.Courses.Include(c => c.CourseLevel).SingleOrDefault(x => x.Id == courseId);

            if (selectedCourse == null)                
                return HttpNotFound();

            return View(selectedCourse);
        }




        private ApplicationDbContext _context;

        //Class constructor
        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }
    }
}