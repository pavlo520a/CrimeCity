using CrimeCity.Models.Crimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees.Positions
{
    public class Policeman : Employee
    {
        public Policeman()
        {
            this.Position = PolicePositions.Policeman;
        }

        public List<Crime> AssignedCrimes { get; set; }
    }
}