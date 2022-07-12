using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class JobCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
