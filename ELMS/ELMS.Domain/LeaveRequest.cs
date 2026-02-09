namespace ELMS.Domain;

public class LeaveRequest
{
    public string EmployeeId { get; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public LeaveType LeaveType { get; private set; }
    public LeaveState State { get; private set; }
    public string Reason { get; private set;  }

    // Constructor enforces ONLY:
    // - structural validity
    // - no overlapping leaves
    public LeaveRequest(
        string employeeId,
        DateTime startDate,
        DateTime endDate,
        LeaveType leaveType,
        IEnumerable<LeaveRequest> existingLeaves,
        string reason = "")
    {
        // 1️ Basic date validation (hard invariant)
        if (startDate.Date > endDate.Date)
            throw new InvalidOperationException("Start date cannot be after end date.");

        // 2️ Past date validation (business invariant for creation)
        if (startDate.Date < DateTime.Today)
            throw new InvalidOperationException("Leave cannot start in the past.");

        // 3️ Overlapping leave validation
        // Rule:
        // New leave overlaps if:
        // new.Start <= existing.End AND new.End >= existing.Start
        bool hasOverlap = existingLeaves.Any(existing =>
            startDate.Date <= existing.EndDate.Date &&
            endDate.Date >= existing.StartDate.Date &&
            existing.State != LeaveState.Cancelled
        );

        if (hasOverlap)
            throw new InvalidOperationException("Leave dates overlap with an existing leave.");

        // 4️ Assign values after all validations pass
        EmployeeId = employeeId;
        StartDate = startDate.Date;
        EndDate = endDate.Date;
        LeaveType = leaveType;
        Reason = reason;

        // 5️⃣ New leave always starts as Pending
        State = LeaveState.Pending;
    }


    public void Approve()
    {
        if (State != LeaveState.Pending)
            throw new InvalidOperationException(
                $"Only pending leave can be approved. Current state: {State}");

        State = LeaveState.Approved;
    }

    public void Reject()
    {
        if (State != LeaveState.Pending)
            throw new InvalidOperationException(
                $"Only pending leave can be rejected. Current state: {State}");

        State = LeaveState.Rejected;
    }

    
    public void Cancel()
    {
        State = State switch
        {
            LeaveState.Pending => LeaveState.Cancelled,
            LeaveState.Approved => LeaveState.Cancelled,
            _ => throw new InvalidOperationException(
                    $"Leave in state {State} cannot be cancelled")
        };
    }
    
}


public enum LeaveDuration
{
    FirstHalf = 0,
    SecondHalf = 1,
    FullDay = 2,
}

public enum LeaveType
{
    Casual = 0,
    Sick = 1,
    Earned = 2,
    PaternityLeave = 3,
    MaternityLeave = 4,
}

public enum LeaveState
{
    Pending = 0,
    Approved = 1,
    Rejected = 2,
    Cancelled = 3
}
