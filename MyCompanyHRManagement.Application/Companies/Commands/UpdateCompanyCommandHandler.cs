using MediatR;
using MyCompanyHRManagement.Application.DTOs;
using MyCompanyHRManagement.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Companies.Commands
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, CompanyDto>
    {
        private readonly ICompanyService _companyService;

        public UpdateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CompanyDto> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.UpdateCompanyAsync(request.Company);
        }
    }
}