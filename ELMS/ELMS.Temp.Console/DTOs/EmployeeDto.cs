namespace ELMS.Temp.Console.DTOs;

// DTO = Data Transfer Object
// Purpose:
// Used ONLY to carry data between layers (Console ↔ Application ↔ API)
// It contains NO business logic and NO validation rules.

public class EmployeeDto
{
    // Public setters are intentional.
    // DTOs are meant to be populated freely at system boundaries
    // (Console input, API request, UI form, etc.)
    public string EmployeeId { get; set; } = string.Empty;

    // DTO does NOT protect invariants.
    // Validation happens in Application / Domain layers.
    public string EmployeeName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string MobileNumber { get; set; } = string.Empty;
}

/*
=====================================================
WHY DTO EXISTS
=====================================================

1. DTO is NOT a domain object
   - It does not represent business rules
   - It does not enforce invariants
   - It does not contain behavior

2. DTO is a BOUNDARY OBJECT
   - Used at system edges:
     Console input
     Web API request

