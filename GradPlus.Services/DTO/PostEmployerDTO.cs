using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Services.DTO
{
    public class PostEmployerDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }     
        public string Profile_Img { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Website { get; set; }
        public int EmployeeCount { get; set; }
        public int YearFounded { get; set; }
       
    }
}
