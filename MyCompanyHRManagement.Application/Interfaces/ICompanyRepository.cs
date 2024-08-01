using MyCompanyHRManagement.Domain.Entities;

namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        // Add any company-specific methods here
    }
}