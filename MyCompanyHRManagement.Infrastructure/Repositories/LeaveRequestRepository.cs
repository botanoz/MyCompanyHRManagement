using MyCompanyHRManagement.Domain.Entities;
using MyCompanyHRManagement.Application.Interfaces;
using MyCompanyHRManagement.Infrastructure.Data;

namespace MyCompanyHRManagement.Infrastructure.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Add any leave request-specific methods here
    }
}