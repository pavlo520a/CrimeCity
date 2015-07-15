using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ContactInfo ContactInformation { get; set; }
        public LocationInfo Address { get; set; }
        private int id;
        public int Id {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
    }

    public enum Sex
    {
        Male = 1,
        Female
    }
}