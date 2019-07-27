using System;
using System.Collections.Generic;
using System.Linq;
using Domein.Interface;
using Domein.Module;
using DomeinService.Mapper;
using Infrastructyre.Interface;

namespace DomeinService.Service
{
    public class UserDomein : IDomeinUser
    {
        private readonly IUserinfrastructyre _repositoryUser;

        public UserDomein(IUserinfrastructyre repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public IList<DomeinUser> GetUsers()
        {
            var users = _repositoryUser.GetUsers();
            return users.Select(_ => _.ToDomein()).ToList();
        }

        public DomeinUser GetUser(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
