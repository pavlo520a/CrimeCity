using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public abstract class PersonModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [EnumDataType(typeof(Sex))]
        public Sex Sex { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public ContactInfoModel ContactInformation { get; set; }
        public LocationInfoModel Address { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public PersonModel()
        {
            ContactInformation = new ContactInfoModel();
            Address = new LocationInfoModel();
        }
    }

    public enum Sex
    {
        Male = 1,
        Female
    }
}