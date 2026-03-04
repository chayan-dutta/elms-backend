using ELMS.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.Infrastructure.Entities;

[Table("leaveApplication")]
public class LeaveApplicationEntity
{
    [Key]
    [Column("leaveId", TypeName = "uuid")]
    public Guid LeaveId { get; set; }

    [Required]
    [Column("employeeId", TypeName = "uuid")]
    public Guid EmployeeId { get; set; }

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
