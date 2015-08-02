using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrimeCity.Models.Employees
{
    public class ContactInfoModel
    {
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email address")] 
        public string Email { get; set; }
        public string Skype { get; set; }
    }
}