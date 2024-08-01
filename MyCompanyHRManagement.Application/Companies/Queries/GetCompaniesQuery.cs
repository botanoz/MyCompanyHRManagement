using MediatR;
using System.Collections.Generic;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Companies.Queries
{
    public class GetCompaniesQuery : IRequest<IEnumerable<CompanyDto>>
    {
    }
}