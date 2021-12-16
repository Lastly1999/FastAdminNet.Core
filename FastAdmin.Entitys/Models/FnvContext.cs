using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FastAdmin.Entitys.Models
{
    public partial class FnvContext : DbContext
    {
        public FnvContext()
        {
        }

        public FnvContext(DbContextOptions<FnvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SysBaseMenu> SysBaseMenu { get; set; }
        public virtual DbSet<SysBasemenuRoles> SysBasemenuRoles { get; set; }
        public virtual DbSet<SysDepartment> SysDepartment { get; set; }
        public virtual DbSet<SysRoles> SysRoles { get; set; }
        public virtual DbSet<SysUserRoles> SysUserRoles { get; set; }
        public virtual DbSet<SysUsers> SysUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //  To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=rm-wz94k0l69605b622nwo.mysql.rds.aliyuncs.com;port=3306;database=fnv;uid=root;pwd=Chen1027;sslmode=none", x => x.ServerVersion("8.0.18-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysBaseMenu>(entity =>
            {
                entity.ToTable("sys_base_menu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .HasComment("权限菜单id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("varchar(255)")
                    .HasComment("图标名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasComment("权限菜单名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parentId")
                    .HasColumnType("int(11)")
                    .HasComment("根菜单id");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasComment("权限菜单路径")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UpdateAt)
                    .HasColumnName("update_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<SysBasemenuRoles>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.RoleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sys_basemenu_roles");

                entity.HasIndex(e => e.MenuId)
                    .HasName("IDX_f80abe58645355546a22c6d3c5");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IDX_87bd6b0b5bbb8d03b6758b74ea");

                entity.Property(e => e.MenuId)
                    .HasColumnName("menu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.SysBasemenuRoles)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_f80abe58645355546a22c6d3c54");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysBasemenuRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_87bd6b0b5bbb8d03b6758b74ea7");
            });

            modelBuilder.Entity<SysDepartment>(entity =>
            {
                entity.ToTable("sys_department");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .HasComment("部门id");

                entity.Property(e => e.DepName)
                    .IsRequired()
                    .HasColumnName("dep_name")
                    .HasColumnType("varchar(255)")
                    .HasComment("部门名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.DepPid)
                    .HasColumnName("dep_pid")
                    .HasColumnType("int(11)")
                    .HasComment("部门父级id");

                entity.Property(e => e.DepStatus)
                    .HasColumnName("dep_status")
                    .HasColumnType("tinyint(4)")
                    .HasComment("启用状态");
            });

            modelBuilder.Entity<SysRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PRIMARY");

                entity.ToTable("sys_roles");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)")
                    .HasComment("角色id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Describe)
                    .HasColumnName("describe")
                    .HasColumnType("varchar(255)")
                    .HasComment("角色别名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasColumnType("varchar(255)")
                    .HasComment("角色名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UpdateAt)
                    .HasColumnName("update_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<SysUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sys_user_roles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IDX_6d61c5b3f76a3419d93a421669");

                entity.HasIndex(e => e.UserId)
                    .HasName("IDX_96311d970191a044ec048011f4");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_6d61c5b3f76a3419d93a4216695");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_96311d970191a044ec048011f44");
            });

            modelBuilder.Entity<SysUsers>(entity =>
            {
                entity.ToTable("sys_users");

                entity.HasIndex(e => e.DepId)
                    .HasName("FK_35bda1c494110e7ec24e32e5500");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .HasComment("用户id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.DepId)
                    .HasColumnName("dep_id")
                    .HasColumnType("int(11)")
                    .HasComment("部门id");

                entity.Property(e => e.NikeName)
                    .IsRequired()
                    .HasColumnName("nike_name")
                    .HasColumnType("varchar(255)")
                    .HasComment("用户昵称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasColumnName("pass_word")
                    .HasColumnType("varchar(255)")
                    .HasComment("账户密码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("role_id")
                    .HasColumnType("varchar(255)")
                    .HasComment("用户角色id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UpdateAt)
                    .HasColumnName("update_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserAvatar)
                    .HasColumnName("user_avatar")
                    .HasColumnType("varchar(255)")
                    .HasComment("用户头像")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(255)")
                    .HasComment("用户名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK_35bda1c494110e7ec24e32e5500");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
