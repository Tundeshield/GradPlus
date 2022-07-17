using GradPlus.Data.Models.Domain;
using GradPlus.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.IServices
{
    public interface IEmployerServices
    {
        void CreateEmployer(PostEmployerDTO employer);
        GetEmployerDTO GetEmployerById(int employerId);
        PostEmployerDTO EditEmployer(int employerID);
        void UpdateEmployer(PostEmployerDTO employer, int employerId);
        void DeleteEmployer(int employerId);
        IList<Employer> GetAllEmployers();
        IList<Job> GetEmployerJobs(int employerId);
    }
}
