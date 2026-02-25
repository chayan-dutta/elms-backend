
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.Infrastructure.Entities;

public class RoleEntity
{
    [Key]
    [Column("roleId", TypeName = "uuid")]
    public Guid RoleId { get; set; }

    [Required]
    [Column("roleName", TypeName = "varchar(100)")]
    public string RoleName { get; set; } = string.Empty;

    [Column("description", TypeName = "varchar(250)")]
    public string? Description { get; set; }

    [Required]
    [Column("isActive", TypeName = "boolean")]
    public bool IsActive { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
