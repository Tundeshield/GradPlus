using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class CompanyCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
    }
}
