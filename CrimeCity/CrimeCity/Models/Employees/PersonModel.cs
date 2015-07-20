using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public abstract class PersonModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ContactInfoModel ContactInformation { get; set; }
        public LocationInfoModel Address { get; set; }
    }

    public enum Sex
    {
        Male = 1,
        Female
    }
}