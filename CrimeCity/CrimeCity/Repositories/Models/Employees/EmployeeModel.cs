using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public class EmployeeModel : PersonModel
    {
        [Range(100, 1000000)]
        public int Salary { get; set; }
        [EnumDataType(typeof(PolicePositions))]
        public PolicePositions Position { get; set; }
    }
}