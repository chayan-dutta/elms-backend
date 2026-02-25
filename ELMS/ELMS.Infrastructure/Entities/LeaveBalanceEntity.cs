using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ELMS.Infrastructure.Entities;

[Table("leaveBalance")]
public class LeaveBalanceEntity
{
    [Key]
    [Column("leaveBalanceId", TypeName = "uuid")]
    public Guid LeaveBalanceId { get; set; }

    [Required]
    [Column("employeeId", TypeName = "uuid")]
    public Guid EmployeeId { get; set; }

    [Required]
    [Column("leaveTypeId", TypeName = "uuid")]
    public Guid LeaveTypeId { get; set; }

    [Required]
    [Column("year", TypeName = "integer")]
    public int Year { get; set; }

    [Required]
    [Column("totalAllocated", TypeName = "integer")]
    public int TotalAllocated { get; set; }

    [Required]
    [Column("used", TypeName = "integer")]
    public int Used { get; set; }

    [Required]
    [Column("remaining", TypeName = "integer")]
    public int Remaining { get; set; }

    [Required]
    [Column("updatedAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset UpdatedAt { get; set; }
}
