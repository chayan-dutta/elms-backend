using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.Infrastructure.Entities;

[Table("leaveType")]
public class LeaveTypeEntity
{
    [Key]
    [Column("leaveTypeId", TypeName = "uuid")]
    public Guid LeaveTypeId { get; set; }

    [Required]
    [Column("typeName", TypeName = "varchar(100)")]
    public string TypeName { get; set; } = string.Empty;

    [Column("description", TypeName = "varchar(250)")]
    public string? Description { get; set; }

    [Required]
    [Column("maxDaysPerYear", TypeName = "integer")]
    public int MaxDaysPerYear { get; set; }

    [Required]
    [Column("isActive", TypeName = "boolean")]
    public bool IsActive { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
