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
                    Sex = Models.Employees.Sex.Male,
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
                    Sex = Models.Employees.Sex.Male,
                    AssignedCrimes = new List<Crime>()
                    {
                        new Crime()
                        {
                            Name = "Grimm",
                            Description = "Grimm"
                        }
                    }
                },

                new Policeman()
                {
                    FirstName = "Eddy",
                    LastName = "Toyn",
                    Sex = Models.Employees.Sex.Male,
                    AssignedCrimes = new List<Crime>()
                    {
                        new Crime()
                        {
                            Name = "Revers Flash",
                            Description = "Revers Flash"
                        }
                    }
                },

                new Policeman()
                {
                    FirstName = "Lorel",
                    LastName = "Lance",
                    Sex = Models.Employees.Sex.Female,
                    AssignedCrimes = new List<Crime>()
                    {
                        new Crime()
                        {
                            Name = "Merlin",
                            Description = "Destroy Merlin"
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
                   .Where(x => Match(x.FirstName, criteria.FirstName) && Match(x.LastName, criteria.LastName) 
                       && Match(Convert.ToString(x.Sex), Convert.ToString(criteria.Sex))
                       && Match(Convert.ToString(x.Position), Convert.ToString(criteria.Position)))
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
