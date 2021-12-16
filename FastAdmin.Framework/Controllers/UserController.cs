using FastAdmin.Entitys.Models;
using FastAdmin.IDAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FastAdmin.Framework.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserDal _userDal;

        public UserController(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [HttpGet]
        public Task<List<SysUsers>> GetUsers()
        {
            return _userDal.GetUsers();
        }
    }
}
