using ELMS.Domain;
using ELMS.Temp.Console.DTOs;

namespace ELMS.Temp.Console.Services;

public class EmployeeDirectory
{
    // IMPORTANT:
    // This collection is PRIVATE.
    // Outside world must NOT directly manipulate Employees.
    // This class is the single authority over employee data (for now).
    private List<Employee> Employees { get; set; } = new();

    // -------------------------------------------------------
    // RESPONSIBILITY:
    // - Acts as a simple in-memory employee store
    // - Enforces uniqueness rules while creating employees
    // - Translates between DTO and domain object
    //
    // NOTE:
    // DTO usage here is TEMPORARILY acceptable because
    // Console ↔ Application ↔ Domain are still merged.
    // -------------------------------------------------------

    public void CreateEmployee(EmployeeDto employeeDto)
    {
        // BUSINESS RULE ENFORCEMENT:
        // An employee is considered duplicate if
        // ANY of these already exist:
        // - EmployeeId
        // - Email
        // - MobileNumber
        foreach (Employee e in Employees)
        {
            if (string.Equals(e.EmployeeId, employeeDto.EmployeeId) ||
                string.Equals(e.Email, employeeDto.Email) ||
                string.Equals(e.MobileNumber, employeeDto.MobileNumber))
            {
                // Fail fast:
                // Do not allow partial or inconsistent state
                throw new InvalidOperationException(
                    "Entered Employee details already exists");
            }
        }

        // DOMAIN OBJECT CREATION:
        // Convert boundary DTO → domain entity
        Employee employee =
            new Employee(
                employeeDto.EmployeeId,
                employeeDto.EmployeeName,
                employeeDto.Email,
                employeeDto.MobileNumber);

        // STATE CHANGE:
        // Only AFTER all validations pass
        Employees.Add(employee);
    }

    // -------------------------------------------------------
    // QUERY OPERATION (Read-only intent)
    // -------------------------------------------------------
    public EmployeeDto? GetEmployeeDetails(string empId)
    {
        Employee? employee = null;

        // Manual search for now (intentionally no LINQ)
        foreach (Employee emp in Employees)
        {
            if (emp.EmployeeId == empId)
            {
                employee = emp;
                break;
            }
        }

        // Explicit null handling:
        // Caller must decide what to do if not found
        if (employee is null)
            return null;

        // DOMAIN → DTO mapping
        return new EmployeeDto
        {
            EmployeeId = employee.EmployeeId,
            EmployeeName = employee.EmployeeName,
            Email = employee.Email,
            MobileNumber = employee.MobileNumber
        };
    }

    // -------------------------------------------------------
    // COMMAND OPERATION (State-changing intent)
    // -------------------------------------------------------
    public EmployeeDto UpdateMobileNumber(string empId, string mobile)
    {
        Employee? employee = null;

        // Locate employee
        foreach (Employee emp in Employees)
        {
            if (emp.EmployeeId == empId)
            {
                employee = emp;
                break;
            }
        }

        // Guard clause:
        // Never operate on non-existing entity
        if (employee is null)
        {
            throw new InvalidOperationException(
                "Employee not found");
        }

        // BUSINESS DECISION:
        // Updating mobile is allowed only after employee exists
        employee.UpdateMobileNumber(mobile);
        // ↑ IMPORTANT:
        // This assumes Employee exposes behavior,
        // not public setters (domain integrity)

        // Return updated snapshot as DTO
        return new EmployeeDto
        {
            EmployeeId = employee.EmployeeId,
            EmployeeName = employee.EmployeeName,
            Email = employee.Email,
            MobileNumber = employee.MobileNumber
        };
    }
}

