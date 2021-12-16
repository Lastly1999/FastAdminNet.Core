using FastAdmin.Entitys.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FastAdmin.IDAL
{
    public interface IUserDal
    {
        Task<List<SysUsers>> GetUsers();
    }
}
