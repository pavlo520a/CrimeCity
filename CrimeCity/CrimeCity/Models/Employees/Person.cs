using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [EnumDataType(typeof(Sex))]
        public Sex Sex { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public ContactInfo ContactInformation { get; set; }
        public LocationInfo Address { get; set; }
        [ScaffoldColumn(false)]
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