using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MyCompanyHRManagement.Application.DTOs;
using MyCompanyHRManagement.Application.Interfaces;

namespace MyCompanyHRManagement.Application.Companies.Commands
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CompanyDto>
    {
        private readonly ICompanyService _companyService;
        private readonly IEmailService _emailService;

        public CreateCompanyCommandHandler(ICompanyService companyService, IEmailService emailService)
        {
            _companyService = companyService;
            _emailService = emailService;
        }

        public async Task<CompanyDto> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var createdCompany = await _companyService.CreateCompanyAsync(request.Company);

            // Send welcome email
            await _emailService.SendEmailAsync(
                createdCompany.Email,
                "Welcome to MyCompanyHRManagement",
                $"Welcome {createdCompany.Name}! Your account has been successfully created."
            );

            return createdCompany;
        }
    }
}