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
        public ActionResult getCustomer()
        {
            var customer = new Customer()
            {
                Name = "Azi",
                Address = "Montreal, QC, Canada"
            };

            return View(customer);
        }
    }
}