using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class User
    {
        [Key]
        public int ID { get; set; }
     
        public ICollection<JobSeeker> JobSeeker { get; set; }
        public ICollection<Employer> Employer { get; set; }
    }
}
