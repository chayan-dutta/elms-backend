// See https://aka.ms/new-console-template for more information
using ELMS.Temp.Console.DTOs;
using ELMS.Temp.Console.Services;

Console.WriteLine("=================================");
Console.WriteLine(" Welcome to ELMS (Employee LMS) ");
Console.WriteLine("=================================");

// Console is the ENTRY POINT
// It should:
// 1. Take input
// 2. Create DTOs
// 3. Call application/service classes
// 4. Display output

EmployeeDirectory employeeDirectory = new();

try
{
    // -----------------------------
    // Collect input from user
    // -----------------------------
    Console.Write("Enter Employee Id: ");
    string employeeId = Console.ReadLine()!;

    Console.Write("Enter Employee Name: ");
    string employeeName = Console.ReadLine()!;

    Console.Write("Enter Email: ");
    string email = Console.ReadLine()!;

    Console.Write("Enter Mobile Number: ");
    string mobile = Console.ReadLine()!;

    // -----------------------------
    // Create DTO (Boundary Object)
    // -----------------------------
    EmployeeDto employeeDto = new EmployeeDto
    {
        EmployeeId = employeeId,
        EmployeeName = employeeName,
        Email = email,
        MobileNumber = mobile
    };

    // -----------------------------
    // Call application logic
    // -----------------------------
    employeeDirectory.CreateEmployee(employeeDto);

    Console.WriteLine();
    Console.WriteLine("✅ Employee created successfully!");

    // -----------------------------
    // Fetch and display employee
    // -----------------------------
    EmployeeDto? savedEmployee =
        employeeDirectory.GetEmployeeDetails(employeeId);

    if (savedEmployee != null)
    {
        Console.WriteLine();
        Console.WriteLine("Employee Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Id     : {savedEmployee.EmployeeId}");
        Console.WriteLine($"Name   : {savedEmployee.EmployeeName}");
        Console.WriteLine($"Email  : {savedEmployee.Email}");
        Console.WriteLine($"Mobile : {savedEmployee.MobileNumber}");
    }
}
catch (Exception ex)
{
    // Console handles presentation-level errors only
    Console.WriteLine();
    Console.WriteLine("❌ Error occurred:");
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
