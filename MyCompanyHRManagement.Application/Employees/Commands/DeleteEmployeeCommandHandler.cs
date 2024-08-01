using MediatR;
using MyCompanyHRManagement.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Employees.Commands
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetByIdAsync(request.Id);
            if (employee != null)
            {
                await _employeeRepository.DeleteAsync(employee);
            }
            return Unit.Value;
        }
    }
}