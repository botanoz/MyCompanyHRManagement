using MediatR;

namespace MyCompanyHRManagement.Application.Employees.Commands
{
    public class DeleteEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}