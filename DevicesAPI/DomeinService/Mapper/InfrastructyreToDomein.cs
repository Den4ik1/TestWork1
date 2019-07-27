using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domein.Module;
using Infrastructyre.Module;


namespace DomeinService.Mapper
{
    public static class InfrastructyreToDomein
    {
        public static DomeinUser ToDomein(this User @this)
        {
            return  new DomeinUser()
            {
                UserId =  @this.UserId,
                Name = @this.Name,
                Divace = @this.Divace.Select(_ => _.ToDomeinDivace()).ToList()

            };
        }
        
    }
}
