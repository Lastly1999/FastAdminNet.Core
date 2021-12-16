using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FastAdmin.Entitys.Models
{
    public partial class SysBaseMenu
    {
        public SysBaseMenu()
        {
            SysBasemenuRoles = new HashSet<SysBasemenuRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? ParentId { get; set; }
        public string Icon { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<SysBasemenuRoles> SysBasemenuRoles { get; set; }
    }
}
