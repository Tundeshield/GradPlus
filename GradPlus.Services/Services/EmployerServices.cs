using GradPlus.Data.DAO;
using GradPlus.Data.IDAO;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using GradPlus.Services.DTO;
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

        public void CreateEmployer(PostEmployerDTO employer)
        {
            Employer newEmployer = new Employer()
            {
                UserName = employer.UserName,
                Email = employer.Email,
                Profile_Img = employer.Profile_Img,
                CompanyName = employer.CompanyName,
                CompanyDescription = employer.CompanyDescription,
                Website = employer.Website,
                EmployeeCount = employer.EmployeeCount,
                YearFounded = employer.YearFounded

            };
           using (var context= new GradPlusContext())
            {
                employerDAO.CreateEmployer(newEmployer, context);
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
        public GetEmployerDTO GetEmployerById(int employerId)
        {
           using(var context= new GradPlusContext())
            {
                var employer = employerDAO.GetEmployerById(employerId, context);
                GetEmployerDTO employerDTO = new GetEmployerDTO()
                {
                    ID = employer.ID,
                    UserName = employer.UserName,
                    Email = employer.Email,
                    Profile_Img = employer.Profile_Img,
                    CompanyName = employer.CompanyName,
                    CompanyDescription = employer.CompanyDescription,
                    Website = employer.Website,
                    EmployeeCount = employer.EmployeeCount,
                    YearFounded = employer.YearFounded
                };
                return employerDTO;
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
        public void UpdateEmployer(PostEmployerDTO employer, int employerId)
        {
            Employer newEmployer = new Employer()
            {
                UserName = employer.UserName,
                Email = employer.Email,
                Profile_Img = employer.Profile_Img,
                CompanyName = employer.CompanyName,
                CompanyDescription = employer.CompanyDescription,
                Website = employer.Website,
                EmployeeCount = employer.EmployeeCount,
                YearFounded = employer.YearFounded

            };
            using (var context= new GradPlusContext())
            {
                employerDAO.UpdateEmployer(newEmployer, employerId, context);
            }
        }
        public PostEmployerDTO EditEmployer(int employerID)
        {
            using (var context = new GradPlusContext())
            {
                var employer = employerDAO.GetEmployerById(employerID, context);
                PostEmployerDTO employerDTO = new PostEmployerDTO()
                {

                    UserName = employer.UserName,
                    Email = employer.Email,
                    Profile_Img = employer.Profile_Img,
                    CompanyName = employer.CompanyName,
                    CompanyDescription = employer.CompanyDescription,
                    Website = employer.Website,
                    EmployeeCount = employer.EmployeeCount,
                    YearFounded = employer.YearFounded
                };
                return employerDTO;
            }
        }
    }
}
