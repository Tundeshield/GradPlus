using GradPlus.Data.IDAO;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.DAO
{
    public class AdminDAO : IAdminDAO
    {
       
        public IList<Admin> GetAdmins(GradPlusContext context)
        {
            return context.Admins.ToList();
        }     
    }
}
