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
                    },
                    Id = 1,
                    Address = new LocationInfo()
                    {
                        City = "London",
                        Street = "Baker Street",
                        House = "4",
                        Flat = "221B"
                    },
                    DateOfBirth = new DateTime(1988, 12, 5),
                    ContactInformation = new ContactInfo()
                    {
                        Skype = "Holmes_SherlockHolmes",
                        Email = "SherlockHolmes@gmail.com",
                        PhoneNumber = "0635748999"
                    },
                    Salary = 4000
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
                    },
                    Id = 2
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
                    },
                    Id = 3
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
                    },
                    Id = 4
                },

                new Policeman()
                {
                    FirstName = "Yakas'",
                    LastName = "Baba",
                    Sex = Models.Employees.Sex.Female,
                    Id = 5
                }
            };

            
        }
    }
}
