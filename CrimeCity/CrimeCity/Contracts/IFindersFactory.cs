using CrimeCity.Models;
using CrimeCity.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts
{
    public interface IFindersFactory
    {
        List<Employee> FindEmployees(SearchEmployeeCriteria criteria);
        List<Employee> FindEmployees();
    }
}
