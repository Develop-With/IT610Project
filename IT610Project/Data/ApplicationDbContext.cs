using Microsoft.EntityFrameworkCore;
using IT610Project.Models.NEF;

namespace IT610Project.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {

        }

        // Create table NewEquipment
        public DbSet<NewEquipment> NewEquipment { get; set; }

        // Create table AuditLogNewEquipment
        public DbSet<AuditLogNewEquipment> AuditLogNewEquipment { get; set; }

        // Create table UserPermissions
        public DbSet<UserPermissions> UserPermissions { get; set; }

        // Create table AuditLogUserPermissions
        public DbSet<AuditLogUserPermissions> AuditLogUserPermissions { get; set; }
    }
}
