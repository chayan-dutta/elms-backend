namespace ELMS.Domain;

public enum Department
{
    HR = 1,
    IT = 2,
    Finance = 3,
    Sales = 4,
    Operations = 5
}

public enum LeaveStatus
{
    Pending = 1,
    Approved = 2,
    Rejected = 3,
    Cancelled = 4
}

public enum LeaveDurationType
{
    FullDay = 1,
    FirstHalf = 2,
    SecondHalf = 3
}

public enum EmploymentStatus
{
    Active = 1,
    OnProbation = 2,
    Resigned = 3,
    Terminated = 4,
    OnLeave = 5
}

public enum AccountStatus
{
    Active = 1,
    Locked = 2,
    Disabled = 3
}