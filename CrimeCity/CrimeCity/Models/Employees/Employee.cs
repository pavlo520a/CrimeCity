using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public class Employee : Person
    {
        public int Salary { get; set; }
        public PolicePositions Position { get; protected set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Sex + " " + Position + ".";
        }
    }
}