using GradPlus.Data.IDAO;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.DAO
{
    public class EmployerDAO : IEmployerDAO
    {

        //Create Employer
        public void CreateEmployer(Employer employer, GradPlusContext context)
        {
            context.Employers.Add(employer);
            context.SaveChanges();
        }

        //Get Employer By Id
        public Employer GetById(int employerId, GradPlusContext context)
        {
            var employer = context.Employers.Where(e => e.ID == employerId).FirstOrDefault();
            return employer;
        }

        //Delete Employer
        public void DeleteEmployer(int employerId, GradPlusContext context)
        {
            var employer= context.Employers.Where(e => e.ID == employerId).FirstOrDefault();
            context.Employers.Remove(employer);
        }

        //Get all Employers
        public IList<Employer> GetAll(GradPlusContext context)
        {
            return (IList<Employer>)context.Employers.OrderBy(emp => emp.CompanyName);
        }

        //Get Employer Jobs
        public IList<Job> GetEmployerJobs(int employerId, GradPlusContext context)
        {           
            //Get Employer
            var employer= context.Employers.Include(s=> s.Jobs).Where(e => e.ID == employerId).FirstOrDefault();          
            //Get Employer Jobs
            return (IList<Job>)employer.Jobs;
        }

        //Update Employer
        //public void UpdateEmployer(Employer employer, GradPlusContext context)
        //{          
        //}
    }
}
