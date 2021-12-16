using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FastAdmin.Entitys.Models
{
    public partial class SysUsers
    {
        public SysUsers()
        {
            SysUserRoles = new HashSet<SysUserRoles>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string UserAvatar { get; set; }
        public string NikeName { get; set; }
        public string RoleId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int? DepId { get; set; }

        public virtual SysDepartment Dep { get; set; }
        public virtual ICollection<SysUserRoles> SysUserRoles { get; set; }
    }
}
