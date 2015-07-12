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
                }
            };
        }


        public List<Employee> GetDetectives()
        {
            return GetAllEmployees()
                  .Where(x => x.Position == PolicePositions.Detective)
                  .ToList();
        }
    }
}
