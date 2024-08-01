using Microsoft.Extensions.DependencyInjection;
using MyCompanyHRManagement.Application.Interfaces;
using MyCompanyHRManagement.Application.Services;
using System.Reflection;

namespace MyCompanyHRManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            // Register services
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICompanyService, CompanyService>();


            return services;
        }
    }
}