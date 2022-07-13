using System;
using GradPlus.Data.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.IServices
{
    public interface IJobServices
    {
        IList<Job> GetJobs();
    }
}
