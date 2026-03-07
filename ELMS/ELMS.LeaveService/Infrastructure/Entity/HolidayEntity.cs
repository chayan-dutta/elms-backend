using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELMS.LeaveService.Infrastructure.Entity;

/// <summary>
/// Represents a holiday record in the database, including its name, date, description, and related metadata.
/// </summary>
[Table("holiday")]
public class HolidayEntity
{
    /// <summary>
    /// Primary key for the holiday record.
    /// </summary>
    [Key]
    [Column("holidayId", TypeName = "uuid")]
    public Guid HolidayId { get; set; }

    /// <summary>
    /// The display name of the holiday.
    /// </summary>
    [Required]
    [Column("holidayName", TypeName = "varchar(150)")]
    public string HolidayName { get; set; } = string.Empty;

    /// <summary>
    /// The calendar date of the holiday.
    /// </summary>
    [Required]
    [Column("holidayDate", TypeName = "date")]
    public DateTime HolidayDate { get; set; }

    /// <summary>
    /// Optional descriptive text about the holiday.
    /// </summary>
    [Column("description", TypeName = "varchar(250)")]
    public string? Description { get; set; }

    /// <summary>
    /// Indicates whether attendance for this holiday is optional.
    /// </summary>
    [Required]
    [Column("isOptional", TypeName = "boolean")]
    public bool IsOptional { get; set; }

    /// <summary>
    /// Timestamp when the holiday record was created (UTC).
    /// </summary>
    [Required]
    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset CreatedAt { get; set; }
}
