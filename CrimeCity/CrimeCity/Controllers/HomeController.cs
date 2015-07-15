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
        private readonly IFindersFactory finders;

        public HomeController(IFindersFactory finders)
        {
            this.finders = finders;
        }

        public ActionResult Admin()
        {
            return View(new SearchEmployeeModel() {
                SearchResult = finders.FindEmployees()
            });
        }

        [HttpPost]
        public ActionResult Admin(SearchEmployeeModel criteria)
        {
            criteria.SearchResult = finders.FindEmployees(criteria.SearchCriteria);
            return View(criteria);
        }

        public ActionResult Info(string category)
        {
            foreach (var employee in finders.FindEmployees())
            {
                //Чому параметер category порівнюється з ToString()
                if (employee.ToString() == category) //WHAT THE FUCK? ???
                    return View(employee);
            }
            return View();
        }
    }
}