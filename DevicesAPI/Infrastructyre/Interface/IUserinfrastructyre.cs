using System.Collections.Generic;
using Infrastructyre.Module;

namespace Infrastructyre.Interface
{
    public interface IUserinfrastructyre
    {
        IList<User> GetUsers();
        User GetUser(int Id);
    }
}