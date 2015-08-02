using CrimeCity.Contracts;
using CrimeCity.Contracts.Repositories;
using CrimeCity.Models;
using CrimeCity.Models.Employees;
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
            model.SearchCriteria.CheckBoxSex();
            model.SearchResult = repository.FindEmployees(model.SearchCriteria);
            return View(model);
        }

        public ActionResult Info(int category)
        {
            EmployeeModel employee = repository.GetAllEmployees().Find(x => x.Id == category);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Info(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                EmployeeModel employee = repository.GetAllEmployees().Find(x => x.Id == model.Id);
                employee = model;
            }
            return View(model);
        }

    }
}