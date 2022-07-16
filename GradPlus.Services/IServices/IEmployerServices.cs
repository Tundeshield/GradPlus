using GradPlus.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.IServices
{
    public interface IEmployerServices
    {
        void CreateEmployer(Employer employer);
        Employer GetEmployerById(int employerId);
        void UpdateEmployer(Employer employer, int employerId);
        void DeleteEmployer(int employerId);
        IList<Employer> GetAllEmployers();
        IList<Job> GetEmployerJobs(int employerId);
    }
}
