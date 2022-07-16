using GradPlus.Data.DAO;
using GradPlus.Data.IDAO;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using GradPlus.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.Services
{
    public class EmployerServices : IEmployerServices
    {
        private IEmployerDAO employerDAO;

        public EmployerServices()
        {
            employerDAO = new EmployerDAO();
        }



        public void CreateEmployer(Employer employer)
        {
           using (var context= new GradPlusContext())
            {
                employerDAO.CreateEmployer(employer, context);
            }
        }

        public void DeleteEmployer(int employerId)
        {
            using(var context= new GradPlusContext())
            {
                employerDAO.DeleteEmployer(employerId, context);
            }
        }

        public IList<Employer> GetAllEmployers()
        {
           using(var context= new GradPlusContext())
            {
                var employers = employerDAO.GetAllEmployers(context);
                return employers; 
            } 
        }

        public Employer GetEmployerById(int employerId)
        {
           using(var context= new GradPlusContext())
            {
                var employer = employerDAO.GetEmployerById(employerId, context);
                return employer;
            }
        }

        public IList<Job> GetEmployerJobs(int employerId)
        {
            using(var context= new GradPlusContext())
            {
                var employerJobs = employerDAO.GetEmployerJobs(employerId, context);
                return employerJobs;
            }
        }

        public void UpdateEmployer(Employer employer, int employerId)
        {
            using(var context= new GradPlusContext())
            {
                employerDAO.UpdateEmployer(employer, employerId, context);
            }
        }
    }
}
