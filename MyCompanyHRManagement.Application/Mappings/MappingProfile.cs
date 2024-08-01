using AutoMapper;
using MyCompanyHRManagement.Application.DTOs;
using MyCompanyHRManagement.Domain.Entities;

namespace MyCompanyHRManagement.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        }
    }
}