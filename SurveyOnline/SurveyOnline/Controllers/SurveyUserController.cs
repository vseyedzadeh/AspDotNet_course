using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyOnline.Models;
using System.Data.Entity;
using SurveyOnline.ViewModels;

namespace SurveyOnline.Controllers
{
    public class SurveyUserController : Controller
    {
        private ApplicationDbContext _context;


        public SurveyUserController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: SurveyUser
        public ActionResult Index(string searchString, string sortOrder, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.TitleSortParameter = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.TopicSortParameter = sortOrder == "Topic" ? "Topic_desc" : "Topic";

            if (searchString == null)
                searchString = currentFilter;
            

            ViewBag.CurrentFilter = searchString;

            var availableSurvey = _context.Surveys.Include(s => s.Topic);
            if (!String.IsNullOrEmpty(searchString))
            {
                availableSurvey = availableSurvey.Where(s => s.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    availableSurvey = availableSurvey.OrderByDescending(s => s.Title);
                    break;
                case "Topic":
                    availableSurvey = availableSurvey.OrderBy(s => s.Topic);
                    break;
                case "Topic_desc":
                    availableSurvey = availableSurvey.OrderByDescending(s => s.Topic);
                    break;
                default:
                    availableSurvey = availableSurvey.OrderBy(s => s.Title);
                    break;
            }

            return View(availableSurvey.ToList());
        }


        public ActionResult AnswerSurvey(int id)
        {
            var selectedSurvey = _context.Surveys.SingleOrDefault(s => s.ID == id);

            var viewModel = new AnswerSurveyFormViewModel()
            {
                
                Survey = selectedSurvey
                
                
            };

            return View("AnswerSurvey", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("SurveyUser/Save/{id}")]
        public ActionResult Save(SurveyUser surveyUser, int id)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new AnswerSurveyFormViewModel()
                {
                    SurveyUser = surveyUser,
                    
                };

                return View("AnswerSurvey", viewModel);
            }

            surveyUser.SurveyID = id;
            _context.SurveyUsers.Add(surveyUser);
            

            _context.SaveChanges();

            return RedirectToAction("Index", "SurveyUser");

        }
    }
}