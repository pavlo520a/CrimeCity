using CrimeCity.Contracts;
using CrimeCity.Contracts.Repositories;
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
        private readonly IEmployeeRepository repository;

        public HomeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Admin()
        {
            return View(new AdminViewModel() {
                SearchResult = repository.GetAllEmployees()
            });
        }

        [HttpPost]
        public ActionResult Admin(AdminViewModel model)
        {
            model.SearchResult = repository.FindEmployees(model.SearchCriteria);
            return View(model);
        }

        public ActionResult Info(string category)
        {
            foreach (var employee in repository.GetAllEmployees())
            {
                //Чому параметер category порівнюється з ToString()
                if (employee.ToString() == category) //WHAT THE FUCK? ???
                    return View(employee);
            }
            return View();
        }
    }
}