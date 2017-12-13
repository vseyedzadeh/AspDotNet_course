using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyOnline.Models
{
    public class SurveyUser
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]        
        public string Phone { get; set; }

        [Range(10000,500000)]
        public decimal? AnnualIncome { get; set; }

        public Survey Survey { get; set; }
        [Required]
        public int SurveyID { get; set; }

        [Required]
        public string SurveyAnswer { get; set; }
    }
}