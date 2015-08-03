using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models
{
    public class AdminViewModel
    {
        public AdminViewSearchModel SearchCriteria { get; set; }
        public IEnumerable<EmployeeModel> SearchResult { get; set; }
        public EmployeeModel NewEmployee { get; set; }

        public bool IsNotEmpty
        {
            get 
            { 
                return SearchResult != null && 
                       SearchResult.Any(); 
            }
        }

        public AdminViewModel()
        {
            SearchCriteria = new AdminViewSearchModel();
            SearchResult = new List<EmployeeModel>();
        }
    }
}