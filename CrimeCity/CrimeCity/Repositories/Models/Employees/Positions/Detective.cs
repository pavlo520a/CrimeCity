using CrimeCity.Models.Crimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees.Positions
{
    public class Detective : EmployeeModel
    {
        public Detective()
        {
            this.Position = PolicePositions.Detective;
        }

        public List<CrimeModel> AssignedCrimes { get; set; }
    }
}