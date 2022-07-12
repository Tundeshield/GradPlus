using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class Employer
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Profile_Img { get; set; }
        public System.DateTime DateRegistered { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Website { get; set; }
        public int EmployeeCount { get; set; }
        public int YearFounded { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
