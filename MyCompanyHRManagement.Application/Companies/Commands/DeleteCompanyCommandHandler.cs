using MediatR;
using MyCompanyHRManagement.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Companies.Commands
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, Unit>
    {
        private readonly ICompanyRepository _companyRepository;

        public DeleteCompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<Unit> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.GetByIdAsync(request.Id);
            if (company != null)
            {
                await _companyRepository.DeleteAsync(company);
            }
            return Unit.Value;
        }
    }
}