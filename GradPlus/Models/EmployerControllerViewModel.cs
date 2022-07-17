using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GradPlus.Models
{
    public class EmployerControllerViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "Date Registered")]
        public System.DateTime DateRegistered { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Website")]
        public string Website { get; set; }
        [Display(Name = "Employee Count")]
        public int EmployeeCount { get; set; }
        [Display(Name = "Year Founded")]
        public int YearFounded { get; set; }
    }
}