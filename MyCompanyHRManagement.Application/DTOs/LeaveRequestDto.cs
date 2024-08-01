using System;
using MyCompanyHRManagement.Domain.Enums;

namespace MyCompanyHRManagement.Application.DTOs
{
    public class LeaveRequestDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public string Reason { get; set; }
        public LeaveRequestStatus Status { get; set; }
    }
}