using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.AuthService.Infrastructure.Entity;

[Table("userRole")]
public class UserRoleEntity
{
    [Key]
    [Column("userRoleId", TypeName = "uuid")]
    public Guid UserRoleId { get; set; }

    [Required]
    [Column("userId", TypeName = "uuid")]
    public Guid UserId { get; set; }

    [Required]
    [Column("roleId", TypeName = "uuid")]
    public Guid RoleId { get; set; }

    [Required]
    [Column("assignedAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset AssignedAt { get; set; }
}
