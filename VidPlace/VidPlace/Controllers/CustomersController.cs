using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using System.Data.Entity;
using VidPlace.ViewModels;

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

        //Action from Building Form section
        public ActionResult New()
        {
          var viewModel = new CustomerFormModelView()
            {
                Customer = new Customer(),
                Membershiptypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }


        //Adding a new Customer - http post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            //Server side Validation -start
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormModelView()
                {
                    Customer = customer,
                    Membershiptypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            //***Server side Validation - end ****
            if (customer.ID == 0)
            {
                _context.Customers.Add(customer);

            }
            else
            {
                var selectedCustomer = _context.Customers.Single(c => c.ID == customer.ID);
                /*
                 *TryUpdateModel(selectedcustomer)
                 * this the default to update used by Ms but has security problem
                 * work around used mapper
                 */
                selectedCustomer.Name = customer.Name;
                selectedCustomer.Address = customer.Address;
                selectedCustomer.BirthDate = customer.BirthDate;
                selectedCustomer.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                selectedCustomer.MembershipTypeId = customer.MembershipTypeId;
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");

        }


        //Edit Action To edit a customer
        public ActionResult Edit(int id)
        {
            var selectedCustomer = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (selectedCustomer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormModelView
            {
                Customer = selectedCustomer,
                Membershiptypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);

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