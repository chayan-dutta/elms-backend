using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ELMS.Infrastructure.Entities;

[Table("holiday")]
public class HolidayEntity
{
    [Key]
    [Column("holidayId", TypeName = "uuid")]
    public Guid HolidayId { get; set; }

    [Required]
    [Column("holidayName", TypeName = "varchar(150)")]
    public string HolidayName { get; set; } = string.Empty;

    [Required]
    [Column("holidayDate", TypeName = "date")]
    public DateTime HolidayDate { get; set; }

    [Column("description", TypeName = "varchar(250)")]
    public string? Description { get; set; }

    [Required]
    [Column("isOptional", TypeName = "boolean")]
    public bool IsOptional { get; set; }

    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
