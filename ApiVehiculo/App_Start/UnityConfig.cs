using Microsoft.Practices.Unity;
using System.Web.Http;
using ApiVehiculo.App_Start;
using Unity.WebApi;

namespace ApiVehiculo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            Bootstraper.Init(container);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}