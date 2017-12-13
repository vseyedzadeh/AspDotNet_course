using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyOnline.Models
{
    public class Survey
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Survey Question")]
        public string SurveyQuestion { get; set; }

        
        public Topic Topic { get; set; }
        [Required]
        [Display(Name = "Topic")]
        public int TopicID { get; set; }

        [MaxLength(255)]
        public string Author { get; set; }

        [Display(Name = "Deadline")]
        public DateTime? DeadlineDate { get; set; }
    }
}