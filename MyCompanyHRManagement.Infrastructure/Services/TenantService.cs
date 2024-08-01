using MyCompanyHRManagement.Application.Interfaces;
using System;

namespace MyCompanyHRManagement.Infrastructure.Services
{
    public class TenantService : ITenantService
    {
        private Guid _currentTenantId;

        public Guid GetCurrentTenantId()
        {
            return _currentTenantId;
        }

        public void SetTenant(Guid tenantId)
        {
            _currentTenantId = tenantId;
        }
    }
}
