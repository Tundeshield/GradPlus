using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class Job
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string ComapanyEmail { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyAddress { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public Plan Plan { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
        public virtual ICollection<SavedJob> SavedJobs { get; set; }
    }
}
