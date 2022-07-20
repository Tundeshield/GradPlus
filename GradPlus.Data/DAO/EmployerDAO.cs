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
        public Employer GetEmployerById(int employerId, GradPlusContext context)
        {
            var employer = context.Employers.Where(e => e.ID == employerId).FirstOrDefault();
            return employer;
        }

        //Get all Employers
        public IList<Employer> GetAllEmployers(GradPlusContext context)
        {
           return context.Employers.ToList();
        }

        //Get Employer Jobs
        public IList<Job> GetEmployerJobs(int employerId, GradPlusContext context)
        {
            //Get Employer
            var employer = context.Employers.Include(s => s.Jobs).Where(e => e.ID == employerId).FirstOrDefault();
            //Get Employer Jobs
            return (IList<Job>)employer.Jobs;
        }

        public void UpdateEmployer(Employer employer, int employerId, GradPlusContext context)
        {
            context.Employers.Find(employerId).Profile_Img = employer.Profile_Img;
            context.Employers.Find(employerId).CompanyName = employer.CompanyName;
            context.Employers.Find(employerId).CompanyDescription = employer.CompanyDescription;
            context.Employers.Find(employerId).Website = employer.Website;
            context.Employers.Find(employerId).EmployeeCount = employer.EmployeeCount;
            context.Employers.Find(employerId).YearFounded = employer.YearFounded;
            context.SaveChanges();
        }

        //Delete Employer
        public void DeleteEmployer(int employerId, GradPlusContext context)
        {
            var employer = context.Employers.Where(e => e.ID == employerId).FirstOrDefault();
            context.Employers.Remove(employer);
            context.SaveChanges();
        }

    }
}
