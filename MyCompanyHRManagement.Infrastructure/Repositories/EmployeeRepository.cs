using MyCompanyHRManagement.Domain.Entities;
using MyCompanyHRManagement.Application.Interfaces;
using MyCompanyHRManagement.Infrastructure.Data;

namespace MyCompanyHRManagement.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Add any employee-specific methods here
    }
}