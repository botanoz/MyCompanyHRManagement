using MediatR;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Employees.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public int Id { get; set; }
    }
}