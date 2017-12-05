using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class MediasController : Controller
    {
        // GET: Media
        public ActionResult Random()
        {
            var media = new Media();
            media.Name = "Jurasic Park";

            return View(media);
        }

        //viewData is an old way to call view
        public ActionResult RandomViewData()
        {
            var media = new Media();
            media.Name = "Inception";
            media.ID = 11111;

            ViewData["mediaObject"] = media;

            return View();
        }

        //
        public ActionResult ActionResultDemo()
        {
            //return Content("Hello World");
            //return HttpNotFound();
            // return new EmptyResult();
            //return RedirectToAction("Index", "Home");
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});//anonymouse object
        }

        public ActionResult edit(int mediaID)
        {
            return Content("Provided ID = " + mediaID); // we will get error because in routconfig we define id not mediaID
        }

        //PartA:
        /*
        public ActionResult index(int pageIndex, string sortBy)
        {
            return Content("Page Number = " + pageIndex + " Sort By: " + sortBy); //parameter type integer can not be nullable. it's premitive data type
        }*/

        //PartB:
        /* int can not be null (exception: non- nullable)
           to make an int parameter to be optional add the "?"

             */
        [Route("medias/index/{pageIndex:range(1,100)}/{sortBy:maxlength(3)}")]
        public ActionResult index(int pageIndex, string sortBy)
        {
            return Content("Page Number = " + pageIndex + " Sort By: " + sortBy);

        }

        
        /*
        
        public ActionResult index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content("Page Number = " + pageIndex + " Sort By: " + sortBy);

        }*/

        //released action with a attribute route
        [Route("medias/released/{yaer:regex(^(19|20)\\d{2}$)}/{month:regex(0[1-9]|1[0-2])}")]
        public ActionResult released(int? year, int? month)
        {
            if (!year.HasValue)
                year = 2017;
            if (!month.HasValue)
                month = 01;
            return Content("Year is: " + year + "  Month is: " + month);

        }
        
        public ActionResult listCustomer()
        {
            var tempMedia = new Media() { Name = "Pulp Fiction" };
            var tempCustomer = new List<Customer>
            {
                new Customer(){ Name = "Berry Alan"},
                new Customer(){ Name = "Jerry Tom"},
                new Customer(){ Name = "Andy Alex"}
            };

            var viewModelObject = new customerMediaViewModel()
            {
                media = tempMedia,
                customers = tempCustomer

            };
            return View(viewModelObject);
        }

       /* public ActionResult listCustomer()
        {
            var tempMedia = new Media() { Name = "Pulp Fiction" };
            var tempCustomer = new List<Customer>();
            

            var viewModelObject = new customerMediaViewModel()
            {
                media = tempMedia,
                customers = tempCustomer

            };
            return View(viewModelObject);
        }*/


    }
}