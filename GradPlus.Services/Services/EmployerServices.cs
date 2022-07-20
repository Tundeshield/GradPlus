using System;
using GradPlus.Services.IServices;
using GradPlus.Data.DAO;
using GradPlus.Data.IDAO;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradPlus.Services.Models;

namespace GradPlus.Services.Services
{
    public class EmployerServices : IEmployerServices
    {
        IEmployerDAO employerDAO;

        public EmployerServices()
        {
            employerDAO = new EmployerDAO();
        }

        public void PostJobToCollection(Job job, Employer employer)
        {
            using(var context = new GradPlusContext())
            {
                employerDAO.PostJobToCollection(context, job, employer);
            }
        }
    }
}
