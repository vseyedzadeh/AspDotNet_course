using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Phono.Models;
using Phono.ViewModel;

namespace Phono.Controllers
{
    public class BrandsController : Controller
    {
        private ApplicationDbContext _context;

        //Class constructor
        public BrandsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Brands
        public ActionResult Index()
        {
            var brands = _context.Brands.OrderBy(o => o.BrandName).ToList();

            return View(brands);
        }

        public ActionResult AvailablePhone(int brandId)
        {
            //var selectedPhoneList = _context.Phones.Find(brandId);
            var brand = _context.Brands.FirstOrDefault(b => b.ID == brandId);
            if (brand == null)
                return HttpNotFound();

            var viewModel = new BrnadsPhoneViewModel()
            {
                Brand = brand,
                Phone = _context.Phones.OrderByDescending(o => o.DateReleased).Include(t => t.PhoneType).Where(p => p.BrandId == brandId).ToList()
            };
            
            return View(viewModel);
        }
    }
}