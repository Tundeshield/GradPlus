using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.IDAO
{
    public interface IEmployerDAO
    {
        void CreateEmployer(Employer employer, GradPlusContext context);
        Employer GetById(int employerId, GradPlusContext context);
      //  void UpdateEmployer(Employer employer, int employerId, GradPlusContext context);
        void DeleteEmployer(int employerId, GradPlusContext context);
        IList<Employer> GetAll(GradPlusContext context);
        IList<Job> GetEmployerJobs(int employerId, GradPlusContext context);
    }
}
