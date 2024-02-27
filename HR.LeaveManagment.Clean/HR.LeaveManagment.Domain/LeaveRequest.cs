using System.ComponentModel.DataAnnotations.Schema;
using HR.LeaveManagment.Domain.Common;

namespace HR.LeaveManagment.Domain;

public class LeaveRequest:BaseEntity
{
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    
    public DateTime DateRequested { get; set; }
    public string? RequestComments { get; set; }
    
    public bool? Approved { get; set; }
    public bool? Cancelled { get; set; }
    public string RequestingEmployeeId { get; set; } = string.Empty;
}