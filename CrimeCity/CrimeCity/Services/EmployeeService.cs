using CrimeCity.Contracts;
using CrimeCity.Models.Crimes;
using CrimeCity.Models.Employees;
using CrimeCity.Models.Employees.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Models.Employees.Employee> GetAllEmployees()
        {
            return new List<Employee>() 
            {
                new Detective()
                {
                    FirstName = "Sherlock",
                    LastName = "Holmes",
                    AssignedCrimes = new List<Crime>()
                    {
                        new Crime()
                        {
                            Name = "Red Ring",
                            Description = "Red Ring"
                        }
                    }
                },

                new Detective()
                {
                    FirstName = "Nick",
                    LastName = "Burkhardt",
                    AssignedCrimes = new List<Crime>()
                    {
                        new Crime()
                        {
                            Name = "Grimm",
                            Description = "Grimm"
                        }
                    }
                }
            };
        }


        public List<Employee> GetDetectives()
        {
            return GetAllEmployees()
                  .Where(x => x.Position == PolicePositions.Detective)
                  .ToList();
        }


        public List<Employee> GetByCriteria(Models.SearchEmployeeCriteria criteria)
        {
            return GetAllEmployees()
                   .Where(x => Match(x.FirstName, criteria.FirstName) && Match(x.LastName, criteria.LastName))
                   .ToList();
        }

        private bool Match(string modelValue, string criteriaValue) 
        {
            return string.IsNullOrEmpty(criteriaValue) ||
                   (!string.IsNullOrEmpty(modelValue) &&
                   modelValue.ToLower().Contains(criteriaValue.ToLower()));
        }
    }
}
