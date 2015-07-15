using CrimeCity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.BusinessLogic.Finders
{
    public class FindersFactory : IFindersFactory
    { 
        private readonly IEmployeeService employeesRepository;

        public FindersFactory(IEmployeeService employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }

        public List<Models.Employees.Employee> FindEmployees(Models.SearchEmployeeCriteria criteria)
        {
            return new EmployeeFinder(employeesRepository.GetAllEmployees()).Find(criteria);
        }

        public List<Models.Employees.Employee> FindEmployees()
        {
            return employeesRepository.GetAllEmployees();
        }
    }
}