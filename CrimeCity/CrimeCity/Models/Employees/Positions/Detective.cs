using CrimeCity.Models.Crimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees.Positions
{
    public class Detective : Employee
    {
        public Detective()
        {
            this.Position = PolicePositions.Detective;
        }

        public List<Crime> AssignedCrimes { get; set; }
    }
}