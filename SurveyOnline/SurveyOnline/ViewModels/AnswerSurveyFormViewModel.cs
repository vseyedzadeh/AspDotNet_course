using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyOnline.Models;

namespace SurveyOnline.ViewModels
{
    public class AnswerSurveyFormViewModel
    {
        public Survey Survey { get; set; }
        public SurveyUser SurveyUser { get; set; }
    }
}