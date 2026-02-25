using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.Infrastructure.Entities;

[Table("userCredential")]
public class UserCredentialEntity
{
    [Key]
    [Column("userCredentialId", TypeName = "uuid")]
    public Guid UserCredentialId { get; set; }

    [Required]
    [Column("employeeId", TypeName = "uuid")]
    public Guid EmployeeId { get; set; }

    [Required]
    [Column("username", TypeName = "varchar(100)")]
    public string Username { get; set; } = string.Empty;

    [Required]
    [Column("passwordHash", TypeName = "varchar(500)")]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [Column("passwordSalt", TypeName = "varchar(500)")]
    public string PasswordSalt { get; set; } = string.Empty;

    [Required]
    [Column("isLocked", TypeName = "boolean")]
    public bool IsLocked { get; set; }

    [Required]
    [Column("failedLoginAttempts", TypeName = "integer")]
    public int FailedLoginAttempts { get; set; }

    [Column("lastLoginAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset? LastLoginAt { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
