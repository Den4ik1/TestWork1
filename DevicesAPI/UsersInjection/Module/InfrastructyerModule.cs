using Infrastructyre.Interface;
using InfrastructyreService;
using Microsoft.Practices.Unity;

namespace UsersInjection.Module
{
    public class InfrastructyerModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IUserinfrastructyre, FakeUsers>(new ContainerControlledLifetimeManager());
        }
    }
}
