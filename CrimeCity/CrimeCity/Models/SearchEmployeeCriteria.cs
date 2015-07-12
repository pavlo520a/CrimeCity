using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models
{
    public class SearchEmployeeCriteria
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public PolicePositions Position { get; set; }
    }
}