namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface ITenantService
    {
        Guid GetCurrentTenantId();
        void SetTenant(Guid tenantId);
    }
}