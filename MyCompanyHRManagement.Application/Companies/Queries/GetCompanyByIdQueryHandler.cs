using MediatR;
using MyCompanyHRManagement.Application.DTOs;
using MyCompanyHRManagement.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Companies.Queries
{
    public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyDto>
    {
        private readonly ICompanyService _companyService;

        public GetCompanyByIdQueryHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CompanyDto> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            return await _companyService.GetCompanyByIdAsync(request.Id);
        }
    }
}
