using MyCompanyHRManagement.Domain.Entities;

namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        // Add any leave request-specific methods here
    }
}