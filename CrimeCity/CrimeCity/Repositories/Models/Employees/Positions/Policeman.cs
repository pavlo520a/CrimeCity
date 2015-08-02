using CrimeCity.Models.Crimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees.Positions
{
    public class Policeman : EmployeeModel
    {
        public Policeman()
        {
            this.Position = PolicePositions.Policeman;
        }

        public List<CrimeModel> AssignedCrimes { get; set; }
    }
}