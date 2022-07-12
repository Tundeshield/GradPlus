using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class User
    {
        public int ID { get; set; }
       public ICollection<Admin> Admin { get; set; }
        public ICollection<JobSeeker> JobSeeker { get; set; }
        public ICollection<Employer> Employer { get; set; }
    }
}
