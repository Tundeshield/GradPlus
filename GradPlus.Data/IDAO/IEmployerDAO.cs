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
        IList<Employer> GetEmployers(GradPlusContext context);
    }
}
