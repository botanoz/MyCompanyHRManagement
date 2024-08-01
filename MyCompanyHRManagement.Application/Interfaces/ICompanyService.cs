using System.Collections.Generic;
using System.Threading.Tasks;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetAllCompaniesAsync();
        Task<CompanyDto> GetCompanyByIdAsync(int id);
        Task<CompanyDto> CreateCompanyAsync(CompanyDto companyDto);
        Task<CompanyDto> UpdateCompanyAsync(CompanyDto companyDto);
        Task DeleteCompanyAsync(int id);
    }
}