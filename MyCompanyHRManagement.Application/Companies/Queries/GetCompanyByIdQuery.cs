using MediatR;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Companies.Queries
{
    public class GetCompanyByIdQuery : IRequest<CompanyDto>
    {
        public int Id { get; set; }
    }
}