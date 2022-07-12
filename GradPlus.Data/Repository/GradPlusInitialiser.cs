using GradPlus.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Repository
{
    public class GradPlusInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<GradPlusContext>
    {
        protected override void Seed(GradPlusContext context)
        {
            Admin admin1 = new Admin() { Email = "abc@abc.com" };
            Admin admin2 = new Admin() { Email = "123@123.com" };

            context.Admins.Add(admin1);
            context.Admins.Add(admin2);

            context.SaveChanges();
        }

    }
}
