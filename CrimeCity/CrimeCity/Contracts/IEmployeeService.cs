using CrimeCity.Models.Crimes;
using CrimeCity.Models.Employees;
using CrimeCity.Models.Employees.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        List<Employee> GetDetectives();
    }
}
