using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using System;
using UsersInjection;
using UsersInjection.Module;

namespace DevicesAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            RegisterComponents<DomeinModule>(container);
            RegisterComponents<InfrastructyerModule>(container);
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void RegisterComponents<T>(UnityContainer container) where T : IModule, new()
        {
            new T().Register(container);
        }
    }
}