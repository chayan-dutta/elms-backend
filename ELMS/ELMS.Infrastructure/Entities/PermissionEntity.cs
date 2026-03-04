using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ELMS.Infrastructure.Entities;


[Table("permission")]
public class PermissionEntity
{
    [Key]
    [Column("permissionId", TypeName = "uuid")]
    public Guid PermissionId { get; set; }

    [Required]
    [Column("permissionName", TypeName = "varchar(150)")]
    public string PermissionName { get; set; } = string.Empty;

    [Column("description", TypeName = "varchar(250)")]
    public string? Description { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}

