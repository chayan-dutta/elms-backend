using ELMS.Domain;

namespace ELMS.Temp.Console.Services;

public class LeaveWorkflow
{
    public static bool ApproveLeave(LeaveRequest leaveRequest, Employee employee)
    {
        // 1. Guard clause – basic null safety
        ArgumentNullException.ThrowIfNull(leaveRequest);

        ArgumentNullException.ThrowIfNull(employee);

        // 2. Calculate leave duration
        // (Assuming full-day leaves only for now)
        int leaveDays =
            (leaveRequest.EndDate.Date - leaveRequest.StartDate.Date).Days + 1;

        // 3. Consume employee leave balance
        // This will throw if balance is insufficient
        employee.ConsumeLeave(leaveDays);

        // 4. Change leave state
        // This will throw if state transition is invalid
        leaveRequest.Approve();

        return true;
    }

    public static bool RejectLeave(LeaveRequest leaveRequest)
    {
        if (leaveRequest is null)
            throw new ArgumentNullException(nameof(leaveRequest));

        // Reject does NOT touch leave balance
        // because balance is consumed only on approval
        leaveRequest.Reject();

        return true;
    }

    public static bool CancelLeave(LeaveRequest leaveRequest, Employee employee)
    {
        ArgumentNullException.ThrowIfNull(leaveRequest);

        ArgumentNullException.ThrowIfNull(employee);

        int leaveDays =
            (leaveRequest.EndDate.Date - leaveRequest.StartDate.Date).Days + 1;

        // Refund only if it was already approved
        if (leaveRequest.State == LeaveState.Approved)
        {
            employee.RefundLeaveBalance(leaveDays);
        }

        leaveRequest.Cancel();

        return true;
    }
}
