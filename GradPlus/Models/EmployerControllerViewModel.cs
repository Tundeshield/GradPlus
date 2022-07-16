using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradPlus.Models
{
    public class EmployerControllerViewModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Profile_Img { get; set; }
        public System.DateTime DateRegistered { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Website { get; set; }
        public int EmployeeCount { get; set; }
        public int YearFounded { get; set; }
    }
}