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
            return this.transformer.Translate(Model.Employees.ToList());
        }
    }
}