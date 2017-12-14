using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Phono.Models;
using Phono.ViewModel;
using System.Data.Entity.Infrastructure;

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

        //New Brand
        public ActionResult New()
        {
            return View("BrandForm");
        }

        [HttpPost]
        public ActionResult Save(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                
                return View("BrandForm", brand);
            }

            if (brand.ID == 0)
            {
                _context.Brands.Add(brand);
            }
            else
            {
                var brandInDB = _context.Brands.Single(p => p.ID == brand.ID);
                brandInDB.BrandName = brand.BrandName;
                brandInDB.CountryOfOrigin = brand.CountryOfOrigin;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Brands");
        }

        //GET : Brands/Edit
        [Authorize]
        public ActionResult Edit(int brandId)
        {
            var brandInDB = _context.Brands.SingleOrDefault(p => p.ID == brandId);

            if (brandInDB == null)
                return HttpNotFound();            

            return View("BrandForm", brandInDB);
        }

        //GET : Brands/Delete/1
        [Authorize]
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id.HasValue)
            {
                var brand = _context.Brands.Find(id);

                if (brand == null)
                    return HttpNotFound();

                if (saveChangesError.GetValueOrDefault())
                {
                    ViewBag.ErrorMessage = "Delete Failed. Please try again or contact adminstrator";
                }

                return View(brand);
            }
            return HttpNotFound();
        }

        //POST : Brands/Delete/1
        [HttpPost]
        [Authorize]
        public ActionResult Delete(int id)
        {
            try
            {
                var brand = _context.Brands.Find(id);
                if (brand == null)
                    return View("Error");

                _context.Brands.Remove(brand);
                _context.SaveChanges();
            }
            catch (RetryLimitExceededException)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            return RedirectToAction("Index");
        }

    }
}