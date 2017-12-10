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
            var phoneList = _context.Phones.OrderByDescending(o => o.DateReleased).Include(b => b.Brand).ToList();
            return View(phoneList);
        }

        public ActionResult Detail(int phoneId)
        {
            var selectedPhone = _context.Phones.Include(c => c.Brand).Include(pt => pt.PhoneType).SingleOrDefault(p => p.Id == phoneId);
            if (selectedPhone == null)
                return HttpNotFound();

            return View(selectedPhone);
        }
    }
}