using System;
using MyCompanyHRManagement.Domain.Common;
using MyCompanyHRManagement.Domain.Enums;

namespace MyCompanyHRManagement.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public EmployeeRole Role { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}