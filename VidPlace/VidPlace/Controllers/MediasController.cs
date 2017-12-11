using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;
using System.Data.Entity;
using PagedList;

namespace VidPlace.Controllers
{
    // [Authorize]
    public class MediasController : Controller
    {
        [Authorize]
        public ActionResult Index(string searchString, string sortOrder, string currentFilter, int? page)
        {
            
            //making sort order
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParameter = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.GenreSortParameter = sortOrder == "Genre" ? "Genre_desc" : "Genre";

            if (searchString == null)
                searchString = currentFilter;
            else
                page = 1;

            ViewBag.CurentFilter = searchString;

            //add filter by media name
            var medias = _context.Medias.Include(mg => mg.Genre);

            if (!string.IsNullOrEmpty(searchString))
            {
                medias = medias.Where(m => m.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    medias = medias.OrderByDescending(m => m.Name);
                    break;

                case "Genre":
                    medias = medias.OrderBy(m => m.Genre.Name);
                    break;

                case "Genre_desc":
                    medias = medias.OrderByDescending(m => m.Genre.Name);
                    break;

                default:
                    medias = medias.OrderBy(m => m.Name);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
           //It used for dummy data
           // IEnumerable<Media> media = getMedias();

            return View(medias.ToPagedList(pageSize, pageNumber));

        }

        //Detail action To Desplay Media Detail
        public ActionResult Detail(int mediaID)
        {
            var detail = _context.Medias.Include(mg => mg.Genre).Include(mt => mt.MediaType).SingleOrDefault(m => m.ID == mediaID);
            
            if (detail == null)
                return HttpNotFound();

            return View(detail);
        }

        //Action from Building Form section
        //GET: Medias/New
        public ActionResult New()
        {
            var viewModel = new MediaFormModelView()
            {
                Media = new Media(),
                MediaTypeList = _context.MediaTypes.ToList(),
                GenreList = _context.Genres.ToList()
            };

            return View("MediaForm", viewModel);
        }


        //Adding a new Media - http post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Media media)
        {
            //server side validation -start
            if (!ModelState.IsValid)
            {
                var viewModel = new MediaFormModelView()
                {
                    Media = media,
                    MediaTypeList = _context.MediaTypes.ToList(),
                    GenreList = _context.Genres.ToList()
                };
                return View("MediaForm", viewModel);
            }
            //Server side validation -end


            if (media.ID == 0)
            {
                _context.Medias.Add(media);
            }
            else
            {
                var selectedMedia = _context.Medias.Single(c => c.ID == media.ID);
                /*
                 *TryUpdateModel(selectedcustomer)
                 * this the default to update used by Ms but has security problem
                 * work around used mapper
                 */
                selectedMedia.Name = media.Name;
                selectedMedia.MediaTypeID = media.MediaTypeID;
                selectedMedia.ReleaseDate = media.ReleaseDate;
                selectedMedia.GenreID = media.GenreID;
                selectedMedia.NumberInStock = media.NumberInStock;
                selectedMedia.DateAdded = media.DateAdded;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Medias");

        }



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

        //Retrieve data from DummyData
         /* 
        private static IEnumerable<Media> getMedias()
        {
            return new List<Media>
            {
                new Media(){ ID = 1, Name = "Inspection" },
                new Media(){ ID = 2, Name = "Mother"},
                new Media(){ ID = 3, Name = "Game of thrones"}
            };
        }*/

        private ApplicationDbContext _context;

        //Class constructor
        public MediasController()
        {
            _context = new ApplicationDbContext();
        }

    }
}