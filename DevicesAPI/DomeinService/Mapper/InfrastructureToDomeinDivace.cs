using System.Linq;
using Domein.Module;
using Infrastructyre.Module;


namespace DomeinService.Mapper
{
    public static class InfrastructureToDomeinDivace
    {
        public static DomeinDivace ToDomeinDivace(this DivaceInfrastrustyre @this)
        {
            return new DomeinDivace()
            {
                DivaceID =  @this.DivaceID,
                Namedivace =  @this.Namedivace,
                Count = @this.Count
            };
        }
    }
}
