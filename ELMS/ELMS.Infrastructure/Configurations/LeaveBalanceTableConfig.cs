using ELMS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELMS.Infrastructure.Configurations;

public class LeaveBalanceTableConfig : IEntityTypeConfiguration<LeaveBalanceEntity>
{
    public void Configure(EntityTypeBuilder<LeaveBalanceEntity> builder)
    {
        // Relationships
        // One employee have multiple leave balance
        builder
            .HasOne<EmployeeEntity>()
            .WithMany()
            .HasForeignKey(lb => lb.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

        // One leave type might have multiple leave balance
        builder
            .HasOne<LeaveTypeEntity>()
            .WithMany()
            .HasForeignKey(lb => lb.LeaveTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        // Composite Unique Index
        builder.HasIndex(lb => new { lb.EmployeeId, lb.LeaveTypeId, lb.Year })
               .IsUnique();
    }
}
