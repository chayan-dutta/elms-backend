using ELMS.CommonUtils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.LeaveService.Infrastructure.Entity;

/// <summary>
/// Represents a leave application submitted by an employee.
/// </summary>
/// <remarks>Maps to the 'leaveApplication' table in the database.</remarks>
[Table("leaveApplication")]
public class LeaveApplicationEntity
{
    /// <summary>
    /// 
    /// </summary>
    [Key]
    [Column("leaveId", TypeName = "uuid")]
    public Guid LeaveId { get; set; }

    [Required]
    [Column("userId", TypeName = "uuid")]
    public Guid UserId { get; set; }

    [Required]
    [Column("startDate", TypeName = "date")]
    public DateTime StartDate { get; set; }

    [Required]
    [Column("endDate", TypeName = "date")]
    public DateTime EndDate { get; set; }

    [Required]
    [Column("reason", TypeName = "varchar(500)")]
    public string Reason { get; set; } = string.Empty;

    [Required]
    [Column("status", TypeName = "integer")]
    public LeaveStatus Status { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
