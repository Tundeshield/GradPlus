using System;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using GradPlus.Data.IDAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.DAO
{
    public class JobDAO : IJobDAO
    {
        public IList<Job> GetJobs(GradPlusContext context)
        {
            //The implementation will return all the jobs from the database in the form of a list
            return context.Jobs.ToList();
        }

        public Job GetJob(GradPlusContext context, int id)
        {
            //This implementation will return a single job from the list
            return context.Jobs.ToList().Find(x => x.ID == id);
        }

        public void PostJob(GradPlusContext context, Job job)
        {
            //This implementation will create a post job method
            context.Jobs.Add(job);
            context.SaveChanges();

        }
    }
}
