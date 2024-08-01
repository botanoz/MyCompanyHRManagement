using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyCompanyHRManagement.Application.Interfaces;

namespace MyCompanyHRManagement.API.Middleware
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITenantService tenantService)
        {
            var tenantIdString = context.Request.Headers["X-TenantId"].ToString();

            if (!string.IsNullOrEmpty(tenantIdString))
            {
                if (Guid.TryParse(tenantIdString, out Guid tenantId))
                {
                    tenantService.SetTenant(tenantId);
                }
                else
                {
                    throw new ArgumentException("Invalid tenant ID format");
                }
            }

            await _next(context);
        }
    }
}
