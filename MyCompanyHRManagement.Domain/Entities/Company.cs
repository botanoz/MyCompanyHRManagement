using System;
using MyCompanyHRManagement.Domain.Common;

namespace MyCompanyHRManagement.Domain.Entities
{
    public class Company : BaseEntity
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime SubscriptionEndDate { get; set; }
    }
}