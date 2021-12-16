// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FastAdmin.Entitys.Models
{
    public partial class SysBasemenuRoles
    {
        public int MenuId { get; set; }
        public int RoleId { get; set; }

        public virtual SysBaseMenu Menu { get; set; }
        public virtual SysRoles Role { get; set; }
    }
}
