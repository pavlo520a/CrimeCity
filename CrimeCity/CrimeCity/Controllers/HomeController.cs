using CrimeCity.Contracts;
using CrimeCity.Models;
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

        public HomeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public ActionResult Admin()
        {
            return View(new SearchEmployeeModel() {
                SearchResult = employeeService.GetAllEmployees()
            });
        }

        [HttpPost]
        public ActionResult Admin(SearchEmployeeModel criteria)
        {
            criteria.SearchResult = employeeService.GetByCriteria(criteria.SearchCriteria);
            return View(criteria);
        }

        public ActionResult Info(string category)
        {
            foreach (var employee in employeeService.GetAllEmployees())
            {
                if (employee.ToString() == category)
                    return View(employee);
            }
            return View();
        }
    }
}