using GradPlus.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GradPlus.Data.Repository
{
    public class GradPlusContext:DbContext
    {
        public GradPlusContext() : base("GradPlusContext")
        {
            Database.SetInitializer(new GradPlusInitialiser());
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CompanyCategory> CompanyCategories { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<SavedJob> SavedJobs { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<User> Users { get; set; }

    }


}
