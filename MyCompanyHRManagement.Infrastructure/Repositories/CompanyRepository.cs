using MyCompanyHRManagement.Domain.Entities;
using MyCompanyHRManagement.Application.Interfaces;
using MyCompanyHRManagement.Infrastructure.Data;

namespace MyCompanyHRManagement.Infrastructure.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Add any company-specific methods here
    }
}