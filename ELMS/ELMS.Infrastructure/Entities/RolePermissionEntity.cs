using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.Infrastructure.Entities;

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
