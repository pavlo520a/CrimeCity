using CrimeCity.Contracts;
using CrimeCity.Models;
using CrimeCity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrimeCity.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public HomeController()
        {
            employeeService = new EmployeeService();
        }

        public ActionResult Admin()
        {
            return View(new SearchEmployeeModel());
        }

        [HttpPost]
        public ActionResult Admin(SearchEmployeeModel criteria)
        {
            criteria.SearchResult = employeeService.GetByCriteria(criteria.SearchCriteria);
            return View(criteria);
        }
    }
}