using MediatR;

namespace MyCompanyHRManagement.Application.Companies.Commands
{
    public class DeleteCompanyCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}