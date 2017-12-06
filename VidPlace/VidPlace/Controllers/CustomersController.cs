using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<Customer> customer = getCustomers();

            return View(customer);
        }

        public ActionResult Detail(int customerID)
        {
            var customers = getCustomers().FirstOrDefault(x => x.ID == customerID);
            if(customers == null)
                throw new HttpException(404, "Some description");
            return View(customers);
        }


        private static IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer(){ ID = 1, Name = "vaji", Address = "Montreal, QC, Canada" },
                new Customer(){ ID = 2, Name = "Azi", Address = "Montreal, QC, Canada"},
                new Customer(){ ID = 3, Name = "Mehrshad", Address = "Montreal"}
            };
        }

    }
}