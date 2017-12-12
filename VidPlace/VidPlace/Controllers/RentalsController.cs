using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.ViewModels;
using System.Data.Entity;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class RentalsController : Controller
    {
        //Class Variables
        private ApplicationDbContext _context;

        //Class constructor
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        //Get : Rentals/Create
        public ActionResult Create(int id, string searchString)
        {
            var viewModel = new RentalFormViewModel();
            viewModel.Customer = _context.Customers.Find(id);
            
            if (viewModel.Customer == null)
                return HttpNotFound();

            if (!String.IsNullOrWhiteSpace(searchString))
            {
                viewModel.Medias = _context.Medias.Where(m => m.Name.Contains(searchString)).ToList();                
            }

            return View(viewModel);
        }

        //POST: Rentals/Create
        [HttpPost]
        public ActionResult Create()
        {
            return View("");
        }
    }
}