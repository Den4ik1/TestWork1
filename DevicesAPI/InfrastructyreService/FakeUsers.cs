using Infrastructyre.Interface;
using Infrastructyre.Module;
using System.Collections.Generic;
using System.Linq;
using System;

namespace InfrastructyreService
{
    public class FakeUsers : IUserinfrastructyre
    {

#region
        List<User> UserDB = new List<User> ()
        {
            new User()
            {
                UserId = 1, Name =  "Jan", Divace = new List<DivaceInfrastrustyre>() {
                 new DivaceInfrastrustyre()
                 {
                    DivaceID = 1,
                    Namedivace = "Phone",
                    Count = 2
                    }
                }
            },
            new User()
            {
                UserId = 2, Name =  "Ivan", Divace = new List<DivaceInfrastrustyre>() {
                new DivaceInfrastrustyre()
                {
                    DivaceID = 1,
                    Namedivace = "IPod",
                    Count = 2
                },
              
                new DivaceInfrastrustyre()
                {
                    DivaceID = 2,
                    Namedivace = "Xbox one",
                    Count = 1
                },

                new DivaceInfrastrustyre()
                {
                    DivaceID = 3,
                    Namedivace = "Photo",
                    Count = 0
                 },
                 },
            },
            new User()  {UserId = 3, Name =  "Alex", Divace = new List<DivaceInfrastrustyre>() {
                    new DivaceInfrastrustyre()
                    {
                        DivaceID = 1,
                        Namedivace = "PC",
                        Count = 1
                    },

                    new DivaceInfrastrustyre()
                    {
                        DivaceID = 2,
                        Namedivace = "Lamp",
                        Count = 5
                    },

                },
            }
        };
#endregion  //DB //DB
        
        public IList<User> GetUsers()
        {
           return UserDB;
        }

        public User GetUser(int Id)
        {
            return  UserDB.FirstOrDefault(_ => _.UserId == Id);
        }
    }
}
