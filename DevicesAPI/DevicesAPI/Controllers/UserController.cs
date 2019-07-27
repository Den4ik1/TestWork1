using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Proxies;
using System.Linq;
using System.Security.Policy;
using System.Web.Http;
using DevicesAPI.Mapper;
using DevicesAPI.Models;
using Domein.Interface;

namespace DevicesAPI.Controllers
{
    [RoutePrefix ("user")]
    public class UserController : ApiController
    {
        private readonly IDomeinUser  _userService;

        public UserController(IDomeinUser userService)
        {
            _userService = userService;
        }

        [HttpGet, Route ("")]
        public List<UserService> Get()
        {
            var users = _userService.GetUsers();
            return users.Select(_ => _.ToView()).ToList();
        }

        [HttpGet, Route("{Id:int}")]
        public UserService Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}