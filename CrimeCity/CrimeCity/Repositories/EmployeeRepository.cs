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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ITransformer<EmployeeModel, Employee> transformer;

        public EmployeeRepository(ITransformer<EmployeeModel, Employee> transformer)
        {
            this.transformer = transformer;
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            List<Employee> result = new List<Employee>();

            using (var context = new DB.CrimeCityModel())
                result.AddRange(context.Employees);

            return this.transformer.Translate(result);
        }

        public IEnumerable<EmployeeModel> FindEmployees(AdminViewSearchModel criteria)
        {
            List<Employee> result = new List<Employee>();
            
            using (var context = new DB.CrimeCityModel()) 
                result.AddRange(context.Employees.Where(x=>Apply(criteria, x)));

            return this.transformer.Translate(result);
        }

        private bool Apply(AdminViewSearchModel criteria, Employee employee) 
        {
            return !string.IsNullOrEmpty(criteria.FirstName) ? employee.Person.FirstName.Contains(criteria.FirstName) : true &&
                   !string.IsNullOrEmpty(criteria.LastName) ? employee.Person.LastName.Contains(criteria.LastName) : true &&
                   !criteria.CheckBoxFemale.Equals(criteria.CheckBoxMale) ? criteria.CheckBoxMale == employee.Person.Male : true;                   
        }
    }
}