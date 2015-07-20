using CrimeCity.Contracts;
using CrimeCity.DB;
using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.BusinessLogic.Transformers
{
    public class EmployeeTransformer : CollectionTransformer<EmployeeModel, Employee>
    {
        public override Models.Employees.EmployeeModel Translate(DB.Employee from)
        {
            return new Models.Employees.Positions.Detective() 
            {
                FirstName = from.Person.FirstName,
                LastName = from.Person.LastName,
                Sex = from.Person.Male ? Models.Employees.Sex.Male 
                                       : Models.Employees.Sex.Female,
            };
        }
    }
}