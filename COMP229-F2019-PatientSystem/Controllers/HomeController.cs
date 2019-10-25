using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_F2019_PatientSystem.Models;


namespace COMP229_F2019_PatientSystem.Controllers 
{
    public class HomeController : Controller
    {
        // default action method
        public ViewResult Index()
        {
            return View();
        }
        /// <summary>
        /// This method returns PatientRegistrationForm view (GET)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult PatientRegistrationForm()
        {
            ViewBag.Date = DateTime.Now;
            return View();
        }
        /// <summary>
        /// This method is used to save the new patient into the PatientList (POST)
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        [HttpPost]
        public ViewResult PatientRegistrationForm(Patient patient)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Date = DateTime.Now;
                Repository.AddPatient(patient);
                return View("Thanks", patient);
            }
            else
            {
                return View();
            }
        }
        /// <summary>
        /// This method returns PatientList view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult PatientList()
        {
            return View(Repository.PatientList);
        }
    }
}
