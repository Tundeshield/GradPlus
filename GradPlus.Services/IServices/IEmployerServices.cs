using GradPlus.Data.Models.Domain;
using GradPlus.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.IServices
{
    public interface IEmployerServices
    {
        void PostJobToCollection(Job job, Employer employer);
    }
}
