using ELMS.LeaveService.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace ELMS.LeaveService.Infrastructure.DatabaseContext;


public class LeaveServiceDbContext(DbContextOptions<LeaveServiceDbContext> options) 
    : DbContext(options)
{
    public DbSet<LeaveApplicationEntity> LeaveApplications { get; set; }
    public DbSet<LeaveBalanceEntity> LeaveBalances { get; set; }
    public DbSet<HolidayEntity> Holidays { get; set; }
    public DbSet<LeaveApprovalHistoryEntity> LeaveApprovalHistories { get; set; }
    public DbSet<LeaveTypeEntity> leaveTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveServiceDbContext).Assembly);
    }

}
