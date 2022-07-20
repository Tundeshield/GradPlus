using GradPlus.Data.Models.Domain;
using GradPlus.Services.IServices;
using GradPlus.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradPlus.Controllers
{
    public class Helper
    {
        IJobServices jobServices;

        public Helper()
        {
            jobServices = new JobServices();
        }

        List<SelectListItem> GetJobDropDown(int id)
        {
            List<SelectListItem> jobList = new List<SelectListItem>();
            IList<Job> job = (IList<Job>)jobServices.GetJob(id);

            foreach( var item in job)
            {
                jobList.Add(
                    new SelectListItem()
                    {
                        Text = item.CompanyName,
                        Value = item.ID.ToString(),
                        Selected = (item.CompanyName == (job[0].CompanyName) ? true : false)
                    });
            }
            return jobList;
        }
    }
}