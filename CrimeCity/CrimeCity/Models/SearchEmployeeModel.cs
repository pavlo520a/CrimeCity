using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Models
{
    public class SearchEmployeeModel
    {
        public SearchEmployeeCriteria SearchCriteria { get; set; }
        public List<Employee> SearchResult { get; set; }

        public bool IsNotEmpty
        {
            get { return SearchResult.Count > 0; }
        }

        public SearchEmployeeModel()
        {
            SearchCriteria = new SearchEmployeeCriteria();
            SearchResult = new List<Employee>();
        }
    }
}