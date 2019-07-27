using System.Collections.Generic;

namespace Infrastructyre.Module
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public IList<DivaceInfrastrustyre> Divace { get; set; }
    }
}
