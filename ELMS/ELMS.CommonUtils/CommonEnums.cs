namespace ELMS.CommonUtils;

/// <summary>
/// Represents the departments within the organization.
/// </summary>
public enum Department
{
    /// <summary>
    /// Human Resources department.
    /// </summary>
    HR = 1,

    /// <summary>
    /// Information Technology department.
    /// </summary>
    IT = 2,

    /// <summary>
    /// Finance department.
    /// </summary>
    Finance = 3,

    /// <summary>
    /// Sales department.
    /// </summary>
    Sales = 4,

    /// <summary>
    /// Operations department.
    /// </summary>
    Operations = 5
}

/// <summary>
/// Represents the status of a leave request.
/// </summary>
public enum LeaveStatus
{
    /// <summary>
    /// The leave request has been created and is awaiting review.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// The leave request has been approved.
    /// </summary>
    Approved = 2,

    /// <summary>
    /// The leave request has been rejected.
    /// </summary>
    Rejected = 3,

    /// <summary>
    /// The leave request has been cancelled by the requester.
    /// </summary>
    Cancelled = 4
}

/// <summary>
/// Indicates the duration type for a leave day.
/// </summary>
public enum LeaveDurationType
{
    /// <summary>
    /// A full day leave.
    /// </summary>
    FullDay = 1,

    /// <summary>
    /// First half of the day.
    /// </summary>
    FirstHalf = 2,

    /// <summary>
    /// Second half of the day.
    /// </summary>
    SecondHalf = 3
}

/// <summary>
/// Represents the employment status of an employee.
/// </summary>
public enum EmploymentStatus
{
    /// <summary>
    /// Employee is actively employed.
    /// </summary>
    Active = 1,

    /// <summary>
    /// Employee is on probation.
    /// </summary>
    OnProbation = 2,

    /// <summary>
    /// Employee has resigned.
    /// </summary>
    Resigned = 3,

    /// <summary>
    /// Employee has been terminated.
    /// </summary>
    Terminated = 4,

    /// <summary>
    /// Employee is currently on leave.
    /// </summary>
    OnLeave = 5
}

/// <summary>
/// Represents the account status for user accounts.
/// </summary>
public enum AccountStatus
{
    /// <summary>
    /// Account is active and usable.
    /// </summary>
    Active = 1,

    /// <summary>
    /// Account is locked due to security or policy reasons.
    /// </summary>
    Locked = 2,

    /// <summary>
    /// Account has been disabled and cannot be used.
    /// </summary>
    Disabled = 3
}