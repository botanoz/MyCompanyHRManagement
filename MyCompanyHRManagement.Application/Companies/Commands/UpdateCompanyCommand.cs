using MediatR;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Companies.Commands
{
    public class UpdateCompanyCommand : IRequest<CompanyDto>
    {
        public CompanyDto Company { get; set; }
    }
}