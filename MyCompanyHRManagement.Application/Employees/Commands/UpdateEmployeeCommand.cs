using MediatR;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Employees.Commands
{
    public class UpdateEmployeeCommand : IRequest<EmployeeDto>
    {
        public EmployeeDto Employee { get; set; }
    }
}