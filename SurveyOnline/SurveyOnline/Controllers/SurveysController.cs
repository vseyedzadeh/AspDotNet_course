using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyOnline.ViewModels;
using System.Data.Entity;
using SurveyOnline.Models;
using System.Data.Entity.Infrastructure;

namespace SurveyOnline.Controllers
{
    [Authorize]
    public class SurveysController : Controller
    {
        
        private ApplicationDbContext _context;

        
        public SurveysController()
        {
            _context = new ApplicationDbContext();
        }

        // Display Form to Create New Survey        
        public ActionResult Index()
        {
            var viewModel = new SurveyFormViewModel()
            {
                TopicList = _context.Topics.ToList()
            };

            return View("SurveyForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]        
        public ActionResult Save(Survey survey)
        {
            
            if (!ModelState.IsValid)
            {
                var viewModel = new SurveyFormViewModel()
                {
                    Survey = survey,
                    TopicList = _context.Topics.ToList()                    
                };

                return View("SurveyForm", viewModel);
            }
            
            if (survey.ID == 0)
            {
                 _context.Surveys.Add(survey);
            }
            else
            {
                var selectedSurvey = _context.Surveys.Single(c => c.ID == survey.ID);

                selectedSurvey.Title = survey.Title;
                selectedSurvey.SurveyQuestion = survey.SurveyQuestion;
                selectedSurvey.TopicID = survey.TopicID;
                selectedSurvey.Author = survey.Author;
                selectedSurvey.DeadlineDate = survey.DeadlineDate;

            }

            _context.SaveChanges();

            return RedirectToAction("SurveyList", "Surveys");
        }

        //Get : Survey's List
        public ActionResult SurveyList()
        {
            var SurveyList = _context.Surveys.Include(c => c.Topic).ToList();
            return View(SurveyList);
        }

        public ActionResult Detail(int id)
        {
            
            var selectedSurvey = _context.Surveys.Include(c => c.Topic).SingleOrDefault(s => s.ID == id);
            if (selectedSurvey == null)
                return HttpNotFound();

            return View(selectedSurvey);
        }


        //Edit action to edit a survey        
        public ActionResult Edit(int id)
        {
            var selectedsurvey = _context.Surveys.SingleOrDefault(c => c.ID == id);

            if (selectedsurvey == null)
                return HttpNotFound();

            var viewModel = new SurveyFormViewModel()
            {
                Survey = selectedsurvey,
                TopicList = _context.Topics.ToList()

            };

            return View("SurveyForm", viewModel);
        }


        //GET : Surveys/Delete        
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id.HasValue)
            {
                var survey = _context.Surveys.Find(id);

                if (survey == null)
                    return HttpNotFound();

                if (saveChangesError.GetValueOrDefault())
                {
                    ViewBag.ErrorMessage = "Delete Failed. Please try again or contact adminstrator";
                }

                return View(survey);
            }
            return HttpNotFound();
        }

        //POST : Surveys/Delete
        [HttpPost]        
        public ActionResult Delete(int id)
        {
            try
            {
                var survey = _context.Surveys.Find(id);
                if (survey == null)
                    return View("Error");

                _context.Surveys.Remove(survey);
                _context.SaveChanges();
            }
            catch (RetryLimitExceededException)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            return RedirectToAction("SurveyList");
        }


    }
}