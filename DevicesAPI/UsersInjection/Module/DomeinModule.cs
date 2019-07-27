using DomeinService.Service;
using Domein.Interface;
using Microsoft.Practices.Unity;

namespace UsersInjection.Module
{
    public class DomeinModule : IModule

    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDomeinUser, UserDomein>( new ContainerControlledLifetimeManager());
        }
    }
}
