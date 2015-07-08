using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrimeCity.Startup))]
namespace CrimeCity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
