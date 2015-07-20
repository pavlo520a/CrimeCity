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
        public List<EmployeeModel> SearchResult { get; set; }

        public bool IsNotEmpty
        {
            get { return SearchResult.Count > 0; }
        }

        public AdminViewModel()
        {
            SearchCriteria = new AdminViewSearchModel();
            SearchResult = new List<EmployeeModel>();
        }
    }
}