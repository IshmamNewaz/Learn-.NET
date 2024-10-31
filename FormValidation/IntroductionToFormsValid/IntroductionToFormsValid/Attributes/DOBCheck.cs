using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace IntroductionToFormsValid.Attributes
{
    public class DOBCheck:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime DOB = Convert.ToDateTime(value);
            if (DateTime.Now.Subtract(DOB).TotalDays<7305) {
                return new ValidationResult("The Person has to be 20 years old or above");
            }
            return ValidationResult.Success;
        }
    }
}