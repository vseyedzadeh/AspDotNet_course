using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phono.Models;
using System.Data.Entity;
using Phono.ViewModel;
using System.Data.Entity.Infrastructure;

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

        // GET: PhoneList
        public ActionResult Index()
        {
            var phoneList = _context.Phones.OrderByDescending(o => o.DateReleased).Include(b => b.Brand).ToList();
            return View(phoneList);
        }

        public ActionResult Detail(int phoneId)
        {
            var selectedPhone = _context.Phones.Include(c => c.Brand).Include(pt => pt.PhoneType).SingleOrDefault(p => p.ID == phoneId);
            if (selectedPhone == null)
                return HttpNotFound();

            return View(selectedPhone);
        }

        //Get: Phone/New
        public ActionResult New()
        {
            var viewModel = new PhoneFormViewModel()
            {
                BrandsList = _context.Brands.ToList(),
                PhoneTypesList = _context.PhoneTypes.ToList()            
            };

            return View("PhoneForm", viewModel);
        }

        //Post: Phone/Save
        [HttpPost]
        public ActionResult Save(Phone phone)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PhoneFormViewModel()
                {
                    Phone = phone,
                    BrandsList = _context.Brands.ToList(),
                    PhoneTypesList = _context.PhoneTypes.ToList()
                };
                return View("PhoneForm", viewModel);
            }

            if (phone.ID == 0)
            {
                _context.Phones.Add(phone);
            }
            else
            {
                var phoneInDB = _context.Phones.Single(p => p.ID == phone.ID);
                phoneInDB.PhoneName = phone.PhoneName;
                phoneInDB.BrandId = phone.BrandId;
                phoneInDB.PhoneTypeId = phone.PhoneTypeId;
                phoneInDB.ScreenSize = phone.ScreenSize;
                phoneInDB.DateReleased = phone.DateReleased;         
                
            }                            
                _context.SaveChanges();                   

            return RedirectToAction("Index", "Phone");
        }

        //GET : Phone/Edit
        [Authorize]
        public ActionResult Edit(int phoneId)
        {
            var phoneInDB = _context.Phones.SingleOrDefault(p => p.ID == phoneId);

            if (phoneInDB == null)
                return HttpNotFound();

            var viewModel = new PhoneFormViewModel()
            {
                Phone = phoneInDB,
                BrandsList = _context.Brands.ToList(),
                PhoneTypesList = _context.PhoneTypes.ToList()
            };

            return View("PhoneForm", viewModel);
        }

        //GET : Phone/Delete/1
        [Authorize]
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id.HasValue)
            {
                var phone = _context.Phones.Find(id);

                if (phone == null)
                    return HttpNotFound();

                if (saveChangesError.GetValueOrDefault())
                {
                    ViewBag.ErrorMessage = "Delete Failed. Please try again or contact adminstrator";
                }

                return View(phone);
            }
            return HttpNotFound();
        }

        //POST: Phone/Delete/1
        [HttpPost]
        [Authorize]
        public ActionResult Delete(int id)
        {
            try
            {
                var phone = _context.Phones.Find(id);
                if (phone == null)
                    return View("Error");
                _context.Phones.Remove(phone);
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