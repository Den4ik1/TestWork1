using System.Collections.Generic;
using Domein.Module;

namespace Domein.Interface
{
    public interface IDomeinUser
    {
        IList<DomeinUser> GetUsers();
        DomeinUser GetUser(int Id);
    }
}