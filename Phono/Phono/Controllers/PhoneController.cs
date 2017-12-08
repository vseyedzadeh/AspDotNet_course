using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phono.Models;
using System.Data.Entity;

namespace Phono.Controllers
{
    public class PhoneController : Controller
    {
        private ApplicationDbContext _context;

        //Class constructor
        public PhoneController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = _context.Phones.ToList();
            return View();
        }
    }
}