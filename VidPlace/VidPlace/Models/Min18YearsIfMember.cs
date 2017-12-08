using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            //Pay as you go option: Birthday is optional here
            if (customer.MembershipTypeId == MembershipType.PayAsYouGo || customer.MembershipTypeId == MembershipType.Unknown)
            {
                return ValidationResult.Success;
            }

            //Other Plan require age to be over 18
            //check if the date is provided
            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birthday Required");
            }

            //Calculating age and validating input
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success :
                new ValidationResult("Customer has to be over 18 years old.");
            
            
        }
    }
}