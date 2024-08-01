using MediatR;
using MyCompanyHRManagement.Application.DTOs;
using System.Collections.Generic;

namespace MyCompanyHRManagement.Application.Employees.Queries
{
    public class GetEmployeesQuery : IRequest<IEnumerable<EmployeeDto>>
    {
    }
}