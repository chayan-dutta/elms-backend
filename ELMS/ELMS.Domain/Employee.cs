namespace ELMS.Domain;

public class Employee
{
    // get;
    // Read-only property
    // ✔ Value can be assigned ONLY inside the constructor
    // ❌ Cannot be changed after object creation
    // Use when a value is part of the object's identity
    public string EmployeeId { get; } = string.Empty;


    // get; private set;
    // Readable from anywhere
    // Writable ONLY inside this class
    // ✔ External classes can READ the value
    // ❌ External classes CANNOT modify it directly
    // ✔ Modification must happen via methods (controlled mutation)
    public string EmployeeName { get; private set; } = string.Empty;


    // get; private set;
    // Same rule as above
    // Used when the value is mandatory but changes must be validated
    public string Email { get; private set; } = string.Empty;


    // get; private set;
    // Read-only outside, writable only inside the class
    // Protects the internal state from uncontrolled modification
    public string MobileNumber { get; private set; } = string.Empty;


    // Constructor
    // Responsible for creating a VALID Employee object
    // Enforces domain rules at birth
    public Employee(string employeeId, string employeeName, string email, string mobileNumber)
    {
        ArgumentException.ThrowIfNullOrEmpty(employeeId.Trim(), nameof(employeeId));
        ArgumentException.ThrowIfNullOrEmpty(employeeName.Trim(), nameof(employeeName));
        ArgumentException.ThrowIfNullOrEmpty(email.Trim(), nameof(email));
        ArgumentException.ThrowIfNullOrEmpty(mobileNumber.Trim(), nameof(mobileNumber));

        EmployeeId = employeeId;
        EmployeeName = employeeName;
        Email = email;
        MobileNumber = mobileNumber;
    }


    // get; set;
    // Readable AND writable from anywhere
    // ✔ Fast and simple
    // ❌ No protection
    // ❌ No validation
    // Use ONLY for non-critical, non-domain data
    // (We are NOT using this in Phase 0.1 intentionally)
    // Example:
    // public string NickName { get; set; }
}


