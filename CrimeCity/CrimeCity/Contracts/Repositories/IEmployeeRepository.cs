using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Models.Employees.EmployeeModel> GetAllEmployees();
        IEnumerable<Models.Employees.EmployeeModel> FindEmployees(Models.AdminViewSearchModel criteria);
    }
}
