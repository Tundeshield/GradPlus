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
    public class AdminServices : IAdminServices
    {
        private IAdminDAO adminDAO;

        public AdminServices()
        {
            adminDAO = new AdminDAO();
        }

        public IList<Admin> GetAdmins()
        {
            using (var context= new GradPlusContext())
            {
                return adminDAO.GetAdmins(context);
            }
        }
    }
}
