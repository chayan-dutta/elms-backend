using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.AuthService.Infrastructure.Entity;

/// <summary>
/// Junction (bridge) table that implements the many-to-many relationship 
/// between Role and Permission.
///
/// Purpose:
/// - A Role can have multiple Permissions.
/// - A Permission can belong to multiple Roles.
/// - This table links them together.
///
/// Each record represents one Permission assigned to one Role.
///
/// A unique constraint on (RoleId, PermissionId) ensures
/// the same permission is not assigned to the same role twice.
/// </summary>
[Table("rolePermission")]
public class RolePermissionEntity
{
    [Key]
    [Column("rolePermissionId", TypeName = "uuid")]
    public Guid RolePermissionId { get; set; }

    [Required]
    [Column("roleId", TypeName = "uuid")]
    public Guid RoleId { get; set; }

    [Required]
    [Column("permissionId", TypeName = "uuid")]
    public Guid PermissionId { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
