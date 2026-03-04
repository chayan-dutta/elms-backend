using ELMS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELMS.Infrastructure.Configurations;

/// <summary>
/// 
/// </summary>
public class LeaveApplicationTableConfig : IEntityTypeConfiguration<LeaveApplicationEntity>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<LeaveApplicationEntity> builder)
    {
        builder.HasOne<EmployeeEntity>()
            .WithMany()
            .HasForeignKey(e => e.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);


    }
}
