using MediatR;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Companies.Commands
{
    public class CreateCompanyCommand : IRequest<CompanyDto>
    {
        public CompanyDto Company { get; set; }
    }
}
