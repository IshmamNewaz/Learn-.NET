using IntroductionToFormsValid.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroductionToFormsValid.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please provide name")]
        [RegularExpression(@"^[a-zA-Z-.''-'\s]{1,40}$", ErrorMessage = "Name can only Contain alphabets, . -")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d@student\.aiub\.edu$", ErrorMessage = "Email Must Be in XX-XXXXX-X@student.aiub.edu")]
        public string Email { get; set; }
        [Required]
        [DOBCheck]
        public string Age { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "ID Must Be in XX-XXXXX-X")]
        public string Id { get; set; }
    }
}