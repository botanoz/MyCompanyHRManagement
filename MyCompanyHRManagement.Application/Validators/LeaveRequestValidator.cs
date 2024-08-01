using FluentValidation;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Validators
{
    public class LeaveRequestValidator : AbstractValidator<LeaveRequestDto>
    {
        public LeaveRequestValidator()
        {
            RuleFor(x => x.EmployeeId).GreaterThan(0);
            RuleFor(x => x.StartDate).NotEmpty().GreaterThanOrEqualTo(System.DateTime.UtcNow.Date);
            RuleFor(x => x.EndDate).NotEmpty().GreaterThan(x => x.StartDate);
            RuleFor(x => x.LeaveType).IsInEnum();
            RuleFor(x => x.Reason).NotEmpty().MaximumLength(500);
        }
    }
}