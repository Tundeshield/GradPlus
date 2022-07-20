using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.Models
{
    public class PostJobDTO
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string ComapanyEmail { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyAddress { get; set; }
        public string Description { get; set; }
        public int JobCategoryID { get; set; }
        public int Salary { get; set; }
        public int Job { get; set; } //ID of Job

        public int Employer { get; set; } //ID of Employer

    }
}
