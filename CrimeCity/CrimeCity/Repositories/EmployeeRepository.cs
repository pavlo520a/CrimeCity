using CrimeCity.Contracts;
using CrimeCity.Contracts.Repositories;
using CrimeCity.DB;
using CrimeCity.Models;
using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Repositories
{
    public class EmployeeRepository : CrimeCityRepository, IEmployeeRepository
    {
        private readonly ITransformer<EmployeeModel, Employee> transformer;

        public EmployeeRepository(ITransformer<EmployeeModel, Employee> transformer)
        {
            this.transformer = transformer;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return this.transformer.Translate(Model.Employees.ToList());
        }

        public List<EmployeeModel> FindEmployees(AdminViewSearchModel criteria)
        {
            return this.transformer.Translate(Model.Employees.ToList()).Where(x => Match(x.FirstName, criteria.FirstName)
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