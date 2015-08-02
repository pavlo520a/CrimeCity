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
        public Sex Sex { get; set; }
        public PolicePositions Position { get; set; }

        public bool CheckBoxMale { get; set; }
        public bool CheckBoxFemale { get; set; }
        public void CheckBoxSex()
        {
            if (CheckBoxMale == true && CheckBoxFemale == false)
                Sex = Employees.Sex.Male;
            if (CheckBoxMale == false && CheckBoxFemale == true)
                Sex = Employees.Sex.Female;
            if ((CheckBoxMale == true && CheckBoxFemale == true) ||
                (CheckBoxMale == false && CheckBoxFemale == false)) 
                Sex = 0;
        }
    }
}