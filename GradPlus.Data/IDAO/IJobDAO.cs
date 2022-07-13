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
        IList<Job> GetJobs(GradPlusContext context);
    }
}
