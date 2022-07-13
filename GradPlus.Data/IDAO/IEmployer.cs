using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.IDAO
{
    public interface IEmployer
    {
        void CreateEmployer(Employer employer, GradPlusContext context);
        Employer GetById(int employerId, GradPlusContext context);
        void UpdateEmployer(Employer employer, GradPlusContext context);
        void DeleteEmployer(int employerId, GradPlusContext context);
        IList<Employer> GetAll();
        IList<Job> GetEmployerJobs(int employerId);
    }
}
