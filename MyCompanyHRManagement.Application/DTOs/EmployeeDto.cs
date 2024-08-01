using System;
using MyCompanyHRManagement.Domain.Enums;

namespace MyCompanyHRManagement.Application.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public EmployeeRole Role { get; set; }
        public int CompanyId { get; set; }
    }
}