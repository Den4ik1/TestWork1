using System.Collections.Generic;

namespace Domein.Module
{
    public class DomeinUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public IList<DomeinDivace> Divace{ get; set; }
    }
}
