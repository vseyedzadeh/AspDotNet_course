using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using System.Data.Entity;

namespace VidPlace.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();


            //IEnumerable<Customer> customer = getCustomers(); //IEnumerable is lighter than List<>

            return View(customer);
        }

        public ActionResult Detail(int customerID)
        {
            // var customers = getCustomers().FirstOrDefault(x => x.ID == customerID);
            //FirstorDefault means there is atleast one result but singleorDefault means there is only one record
            //In the case of Fist / FirstOrDefault, only one row is retrieved from the database so it performs slightly better than single / SingleOrDefault.
            //adding foreign key by include -- eager loading
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(x => x.ID == customerID);

            //var customers = _context.Customers.FirstOrDefault(x => x.ID == customerID);
            if (customer == null)
                //throw new HttpException(404, "Some description");
                return HttpNotFound();

            return View(customer);
        }

        
         
        //Temp method to provide dummy data
      /*  private static IEnumerable<Customer> getCustomerss()
        {
            return new List<Customer>
            {
                new Customer(){ ID = 1, Name = "vaji", Address = "Montreal, QC, Canada" },
                new Customer(){ ID = 2, Name = "Azi", Address = "Montreal, QC, Canada"},
                new Customer(){ ID = 3, Name = "Mehrshad", Address = "Montreal"}
            };
        }*/
        
        //Class Variables
        private ApplicationDbContext _context;

        //Class constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
    }
}