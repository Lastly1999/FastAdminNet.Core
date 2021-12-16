using FastAdmin.Entitys.Models;
using FastAdmin.IDAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FastAdmin.DAL
{
    public class UserDal : IUserDal
    {
        private readonly FnvContext _fnvContext;
        public UserDal(FnvContext fnvContext)
        {
            _fnvContext = fnvContext;
        }

        /// <summary>
        /// 查询全部用户
        /// </summary>
        /// <returns></returns>
        public async Task<List<SysUsers>> GetUsers()
        {
            return await _fnvContext.SysUsers.ToListAsync();
        }
    }
}
