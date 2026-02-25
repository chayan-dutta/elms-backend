using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.Infrastructure.Entities;

[Table("leaveApprovalHistory")]
public class LeaveApprovalHistoryEntity
{
    [Key]
    [Column("approvalHistoryId", TypeName = "uuid")]
    public Guid ApprovalHistoryId { get; set; }

    [Required]
    [Column("leaveId", TypeName = "uuid")]
    public Guid LeaveId { get; set; }

    [Required]
    [Column("actionByEmployeeId", TypeName = "uuid")]
    public Guid ActionByEmployeeId { get; set; }

    [Required]
    [Column("status", TypeName = "integer")]
    public int Status { get; set; }

    [Column("remarks", TypeName = "varchar(500)")]
    public string? Remarks { get; set; }

    [Required]
    [Column("actionAt", TypeName = "timestamp with time zone")]
    public DateTimeOffset ActionAt { get; set; }
}