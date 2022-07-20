using System;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using GradPlus.Data.IDAO;
using GradPlus.Data.DAO;
using GradPlus.Services.IServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.Services
{
    public class JobServices : IJobServices
    {

        IJobDAO jobDAO;
        public JobServices()
        {
            //instantiation of JobDAO
            jobDAO = new JobDAO();
        }
        public IList<Job> GetJobs()
        {
            using(var context = new GradPlusContext())
            {
                return jobDAO.GetJobs(context);
            }
        }

        public Job GetJob(int id)
        {
            using(var context = new GradPlusContext())
            {
                return jobDAO.GetJob(context,id);
            }
        }
    }
}
