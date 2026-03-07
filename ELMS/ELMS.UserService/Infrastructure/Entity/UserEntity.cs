using ELMS.CommonUtils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.UserService.Infrastructure.Entity;

/// <summary>
/// Represents a user entity in the system, including personal, employment, and organizational details.
/// </summary>
[Table("user")]
public class UserEntity
{
    /// <summary>
    /// 
    /// </summary>
    [Key]
    [Column("userId", TypeName = "uuid")]
    public Guid UserId { get; set; }

    [Required]
    [Column("employeeCode", TypeName = "varchar(50)")]
    public string EmployeeCode { get; set; } = string.Empty;

    [Required]
    [Column("fullName", TypeName = "varchar(100)")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Column("email", TypeName = "varchar(150)")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Column("phoneNumber", TypeName = "varchar(20)")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [Column("dateOfJoining", TypeName = "date")]
    public DateTime DateOfJoining { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [Column("department", TypeName = "integer")]
    public Department Department { get; set; }

    // Self FK → Employee (Manager)
    [Column("managerId", TypeName = "uuid")]
    public Guid? ReportingManagerId { get; set; }

    [Required]
    [Column("employmentStatus", TypeName = "int")]
    public EmploymentStatus EmploymentStatus { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }

    [Column("updatedAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset? UpdatedAt { get; set; }
}
