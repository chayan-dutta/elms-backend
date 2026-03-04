using ELMS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ELMS.Infrastructure.DatabaseContext;

/// <summary>
///     
/// </summary>
/// <param name="options"></param>
public class ElmsDbContext(DbContextOptions<ElmsDbContext> options) : DbContext(options) 
{

    // DbSets (tables)
    public DbSet<EmployeeEntity> Employees { get; set; }
    public DbSet<HolidayEntity> Holidays { get; set; }
    public DbSet<LeaveApplicationEntity> LeaveApplications { get; set; }
    public DbSet<LeaveApprovalHistoryEntity> LeaveApprovalHistories { get; set; }
    public DbSet<LeaveBalanceEntity> LeaveBalanceHistories { get; set; }
    public DbSet<LeaveTypeEntity> LeaveTypes { get; set; }
    public DbSet<PermissionEntity> Permissions {  get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<RolePermissionEntity> RolePermissions { get; set; }
    public DbSet<UserCredentialEntity> UserCredentials { get; set; }
    public DbSet<UserRoleEntity> UserRoles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ElmsDbContext).Assembly);
    }
}
