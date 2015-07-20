using CrimeCity.Contracts;
using CrimeCity.Models;
using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.BusinessLogic.Finders
{
    public class EmployeeFinder : IFinder<EmployeeModel, AdminViewSearchModel>
    {
        private readonly List<EmployeeModel> employees = new List<EmployeeModel>();

        public EmployeeFinder(List<EmployeeModel> employees)
        {
            this.employees = employees;
        }

        public List<EmployeeModel> Find(AdminViewSearchModel criteria)
        {
            return employees.Where(x => Match(x.FirstName, criteria.FirstName) 
                                     && Match(x.LastName, criteria.LastName) 
                                     && Match(Convert.ToString((int)x.Sex), Convert.ToString((int)criteria.Sex))
                                     && Match(Convert.ToString((int)x.Position), Convert.ToString((int)criteria.Position)))
                            .ToList();
        }

        private bool Match(string modelValue, string criteriaValue)
        {
            if (criteriaValue == "0")
                return true;
            return string.IsNullOrEmpty(criteriaValue) ||
                   (!string.IsNullOrEmpty(modelValue) &&
                   modelValue.ToLower().Contains(criteriaValue.ToLower()));
        }
    }
}