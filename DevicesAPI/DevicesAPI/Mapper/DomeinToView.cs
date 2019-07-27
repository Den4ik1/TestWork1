using Domein.Module;
using DevicesAPI.Models;

namespace DevicesAPI.Mapper
{
    public static class DomeinToVeiw
    {
        public static UserService ToView(this DomeinUser @this)
        {
            return  new UserService()
            {
                UserId = @this.UserId,
                Name = @this.Name
            };
        }
    }
}