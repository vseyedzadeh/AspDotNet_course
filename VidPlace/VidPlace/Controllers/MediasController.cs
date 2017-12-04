using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

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
        public ActionResult index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content("Page Number = " + pageIndex + " Sort By: " + sortBy);

        }

       
    }
}