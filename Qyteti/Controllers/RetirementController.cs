using Qyteti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Qyteti.Controllers
{
    public class RetirementController : Controller
    {
        // GET: Retirement
        public ActionResult Index()
        {
            return View(new PersonModel());
        }
        [HttpPost]
        public ActionResult Index(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                var age = CalculateAge(model.DateOfBirth);
                var yearsLeft = 65 - age;
                if (yearsLeft < 0){ 
                    yearsLeft = 0; 
                }

                model.YearsToRetire = yearsLeft;
                model.ResultMessage = $"{model.FirstName} {model.LastName}, do te pensionohesh pas {yearsLeft} vite{(yearsLeft != 1 ? "sh" : "")}";
            }
            return View(model);
        }

        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)){
                age--;
            }   
            return age;
        }
    }
}