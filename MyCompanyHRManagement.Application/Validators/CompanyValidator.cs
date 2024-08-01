using FluentValidation;
using MyCompanyHRManagement.Application.DTOs;

namespace MyCompanyHRManagement.Application.Validators
{
    public class CompanyValidator : AbstractValidator<CompanyDto>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Phone).NotEmpty().Matches(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
            RuleFor(x => x.SubscriptionEndDate).NotEmpty().GreaterThan(System.DateTime.UtcNow);
        }
    }
}