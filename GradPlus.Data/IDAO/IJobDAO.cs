using System;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GradPlus.Data.IDAO
{
    public interface IJobDAO
    {
        //This method will get all list of Jobs
        IList<Job> GetJobs(GradPlusContext context);

        //This method will get a job
        Job GetJob(GradPlusContext context, int id);

        //This method will create a Job post
        void PostJob(GradPlusContext context, Job job);

        //This method will edit a job details
        void EditJob(GradPlusContext context, Job job, int id);
    }
}
