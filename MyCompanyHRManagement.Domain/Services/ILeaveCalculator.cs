using System;
using MyCompanyHRManagement.Domain.Entities;

namespace MyCompanyHRManagement.Domain.Services
{
    public interface ILeaveCalculator
    {
        int CalculateBusinessDays(DateTime startDate, DateTime endDate);
        bool IsLeaveRequestValid(LeaveRequest leaveRequest);
    }
}