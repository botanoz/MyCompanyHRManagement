using MediatR;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Employees.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeDto>
    {
        public EmployeeDto Employee { get; set; }
    }
}