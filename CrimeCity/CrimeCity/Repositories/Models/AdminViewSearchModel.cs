using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models
{
    public class AdminViewSearchModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PolicePositions Position { get; set; }

        public bool CheckBoxMale { get; set; }
        public bool CheckBoxFemale { get; set; }
    }
}