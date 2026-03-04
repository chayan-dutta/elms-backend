using ELMS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ELMS.Infrastructure.Configurations;

/// <summary>
/// Configuration for the LeaveApprovalHistoryEntity table.
/// 
/// Defines the relationship between LeaveApprovalHistory and LeaveApplication.
/// 
/// Relationship:
/// One LeaveApplication can have multiple LeaveApprovalHistory records.
/// Each LeaveApprovalHistory belongs to exactly one LeaveApplication.
/// 
/// Delete Behavior:
/// Cascade delete is configured so that when a LeaveApplication
/// is deleted, all related LeaveApprovalHistory records
/// are automatically removed from the database.
/// 
/// This ensures:
/// - No orphan history records
/// - Data integrity
/// - Proper parent-child behavior
/// </summary>
public class LeaveApprovalHistoryTableConfig : IEntityTypeConfiguration<LeaveApprovalHistoryEntity>
{

    /// <summary>
    /// Configures the entity properties and relationships
    /// for LeaveApprovalHistoryEntity using Fluent API.
    /// </summary>
    /// <param name="builder">
    /// Provides access to Fluent API configuration methods
    /// for LeaveApprovalHistoryEntity.
    /// </param>
    public void Configure(EntityTypeBuilder<LeaveApprovalHistoryEntity> builder)
    {
        /// <summary>
        /// Defines a one-to-many relationship:
        /// LeaveApplication (1) → LeaveApprovalHistory (Many)
        /// 
        /// - LeaveApprovalHistory contains the foreign key (LeaveId).
        /// - LeaveApplication is the principal (parent) entity.
        /// - Cascade delete ensures related history records are
        ///   automatically deleted when the parent leave is removed.
        /// </summary>
        builder.HasOne<LeaveApplicationEntity>()
            .WithMany()
            .HasForeignKey(e => e.LeaveId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
