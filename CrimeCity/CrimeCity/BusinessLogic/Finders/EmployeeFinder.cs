using CrimeCity.Contracts;
using CrimeCity.Models;
using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.BusinessLogic.Finders
{
    public class EmployeeFinder : IFinder<Employee, SearchEmployeeCriteria>
    {
        private readonly List<Employee> employees = new List<Employee>();

        public EmployeeFinder(List<Employee> employees)
        {
            this.employees = employees;
        }

        public List<Employee> Find(SearchEmployeeCriteria criteria)
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