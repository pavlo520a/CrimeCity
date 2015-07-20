using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        List<Models.Employees.EmployeeModel> GetAllEmployees();
        List<Models.Employees.EmployeeModel> FindEmployees(Models.AdminViewSearchModel criteria);
    }
}
