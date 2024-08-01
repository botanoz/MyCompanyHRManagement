using MyCompanyHRManagement.Domain.Entities;

namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        // Add any employee-specific methods here
    }
}