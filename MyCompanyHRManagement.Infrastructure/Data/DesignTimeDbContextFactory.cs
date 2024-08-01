using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using MyCompanyHRManagement.Application.Interfaces;

namespace MyCompanyHRManagement.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // API projesinin yolunu belirtin
            string apiProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "MyCompanyHRManagement.API");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(apiProjectPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new ApplicationDbContext(builder.Options, new DummyTenantService());
        }
    }

    public class DummyTenantService : ITenantService
    {
        public Guid GetCurrentTenantId()
        {
            return Guid.Empty;
        }

        public void SetTenant(Guid tenantId)
        {
            // Design-time factory için boş implementasyon
        }
    }
}