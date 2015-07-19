using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public class Employee : Person
    {
        [Range(1200, 1000000)]
        public int Salary { get; set; }
        [EnumDataType(typeof(PolicePositions))]
        public PolicePositions Position { get; set; }
    }
}