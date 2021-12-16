using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FastAdmin.Entitys.Models
{
    public partial class SysDepartment
    {
        public SysDepartment()
        {
            SysUsers = new HashSet<SysUsers>();
        }

        public int Id { get; set; }
        public string DepName { get; set; }
        public sbyte DepStatus { get; set; }
        public int DepPid { get; set; }

        public virtual ICollection<SysUsers> SysUsers { get; set; }
    }
}
