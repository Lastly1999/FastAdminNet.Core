using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FastAdmin.Entitys.Models
{
    public partial class SysRoles
    {
        public SysRoles()
        {
            SysBasemenuRoles = new HashSet<SysBasemenuRoles>();
            SysUserRoles = new HashSet<SysUserRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Describe { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<SysBasemenuRoles> SysBasemenuRoles { get; set; }
        public virtual ICollection<SysUserRoles> SysUserRoles { get; set; }
    }
}
