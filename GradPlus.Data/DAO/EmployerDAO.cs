using GradPlus.Data.IDAO;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.DAO
{
    public class EmployerDAO : IEmployerDAO
    {
        public IList<Employer> GetEmployers(GradPlusContext context)
        {
            return context.Employers.ToList();
        }

        public Employer GetEmployer(GradPlusContext context, int id)
        {
            return context.Employers.ToList().Find(x => x.ID == id);
        }
        public void PostJobToCollection(GradPlusContext context, Job job, Employer employer)
        {
            context.Employers.Find(job.ID).Jobs.Add(job);
        }
    }
}
