using GradPlus.Models;
using GradPlus.Services.IServices;
using GradPlus.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradPlus.Controllers
{
    public class EmployerController : Controller
    {
        private IEmployerServices employerService;

        public EmployerController()
        {
            employerService = new EmployerServices();
        }

        // GET: Employer
        public ActionResult Index()
        {
            var employers = employerService.GetAllEmployers().Select(employer => new EmployerControllerViewModel
            {
                ID = employer.ID,
                Email = employer.Email,
                DateRegistered = employer.DateRegistered,
                CompanyName = employer.CompanyName,
                Website = employer.Website,
                EmployeeCount = employer.EmployeeCount,
                YearFounded = employer.YearFounded

            }).ToList();
            return View(employers);
        }

        // GET: Employer/Details/5
        public ActionResult GetEmployerDetails(int id)
        {
            try
            {
              var employer=  employerService.GetEmployerById(id);
                return View(employer);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employer/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                employerService.DeleteEmployer(id);
                return RedirectToAction("Index", new { Controller = "Employer" });
            }
            catch
            {
                return View();
            }

           
        }

        // POST: Employer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
