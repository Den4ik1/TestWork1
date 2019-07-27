using Microsoft.Practices.Unity;

namespace UsersInjection
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}