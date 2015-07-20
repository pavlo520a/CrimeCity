using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using CrimeCity.Contracts;
using CrimeCity.BusinessLogic.Finders;
using CrimeCity.Repositories;
using CrimeCity.Contracts.Repositories;
using CrimeCity.BusinessLogic.Transformers;

namespace CrimeCity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ITransformer<CrimeCity.Models.Employees.EmployeeModel, 
                                               CrimeCity.DB.Employee>, 
                                   EmployeeTransformer>();

            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}