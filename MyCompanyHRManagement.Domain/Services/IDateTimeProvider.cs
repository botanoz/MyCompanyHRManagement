using System;

namespace MyCompanyHRManagement.Domain.Services
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}