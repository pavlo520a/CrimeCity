using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using CrimeCity.Contracts;
using CrimeCity.Services;

namespace CrimeCity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IEmployeeService, EmployeeService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}