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
            return context.Jobs.ToList();
        }
    }
}
