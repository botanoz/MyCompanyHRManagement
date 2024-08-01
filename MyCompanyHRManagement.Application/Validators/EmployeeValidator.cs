using FluentValidation;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.DateOfBirth).NotEmpty().LessThan(System.DateTime.UtcNow.AddYears(-18));
            RuleFor(x => x.HireDate).NotEmpty().LessThanOrEqualTo(System.DateTime.UtcNow);
            RuleFor(x => x.CompanyId).GreaterThan(0);
        }
    }
}