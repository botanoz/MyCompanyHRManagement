using System;
using MyCompanyHRManagement.Domain.Common;
using MyCompanyHRManagement.Domain.Enums;

namespace MyCompanyHRManagement.Domain.Entities
{
    public class LeaveRequest : BaseEntity
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public string Reason { get; set; }
        public LeaveRequestStatus Status { get; set; }
    }
}