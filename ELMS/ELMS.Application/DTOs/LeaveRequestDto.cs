using ELMS.Domain;
using System.ComponentModel.DataAnnotations;

namespace ELMS.Application.DTOs;

/// <summary>
/// 
/// </summary>
public class LeaveRequestDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the employee.
    /// </summary>
    [Required]
    public string EmployeeId { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    [Required]
    public Guid EmployeeGuid { get; set; }

    /// <summary>
    /// Gets or sets the start date.
    /// </summary>
    [Required]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the end date.
    /// </summary>
    [Required]
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Gets or sets the type of leave.
    /// </summary>
    [Required]
    public LeaveType LeaveType { get; set; }

    /// <summary>
    /// Gets or sets the reason associated with the operation.
    /// </summary>
    [Required]
    public string Reason { get; set; } = string.Empty;
}
