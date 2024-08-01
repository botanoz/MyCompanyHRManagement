using Microsoft.EntityFrameworkCore;
using MyCompanyHRManagement.Domain.Entities;
using MyCompanyHRManagement.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using MyCompanyHRManagement.Domain.Enums;

namespace MyCompanyHRManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ITenantService _tenantService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ITenantService tenantService)
            : base(options)
        {
            _tenantService = tenantService;
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().HasQueryFilter(c => c.TenantId == _tenantService.GetCurrentTenantId());
            modelBuilder.Entity<Employee>().HasQueryFilter(e => e.Company.TenantId == _tenantService.GetCurrentTenantId());
            modelBuilder.Entity<LeaveRequest>().HasQueryFilter(lr => lr.Employee.Company.TenantId == _tenantService.GetCurrentTenantId());

            Seed(modelBuilder);
            // Diğer entity konfigürasyonları buraya eklenebilir
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<Company>().Where(e => e.State == EntityState.Added))
            {
                entry.Entity.TenantId = _tenantService.GetCurrentTenantId();
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Şirketler
            var companies = new List<Company>
            {
                new Company { Id = 1, Name = "Arçelik A.Ş.", Address = "Karaağaç Caddesi No:2-6 Sütlüce 34445 Beyoğlu Istanbul", Phone = "+90 212 314 34 34", Email = "info@arcelik.com", TenantId = Guid.NewGuid() },
                new Company { Id = 2, Name = "Turkcell İletişim Hizmetleri A.Ş.", Address = "Aydınevler Mahallesi İnönü Caddesi No:20 Küçükyalı Ofispark 34854 Maltepe Istanbul", Phone = "+90 212 313 10 00", Email = "info@turkcell.com.tr", TenantId = Guid.NewGuid() },
                new Company { Id = 3, Name = "Ülker Bisküvi Sanayi A.Ş.", Address = "Kısıklı Mahallesi Ferah Caddesi No:1 34692 Büyük Çamlıca Üsküdar Istanbul", Phone = "+90 216 524 25 00", Email = "info@ulker.com.tr", TenantId = Guid.NewGuid() },
                new Company { Id = 4, Name = "Pegasus Hava Taşımacılığı A.Ş.", Address = "AEROPARK Yenişehir Mahallesi Osmanlı Bulvarı No: 11/A Kurtköy 34912 Pendik Istanbul", Phone = "+90 216 560 70 00", Email = "info@flypgs.com", TenantId = Guid.NewGuid() },
                new Company { Id = 5, Name = "Koç Holding A.Ş.", Address = "Nakkaştepe Azizbey Sokak No:1 34674 Kuzguncuk Üsküdar Istanbul", Phone = "+90 216 531 00 00", Email = "info@koc.com.tr", TenantId = Guid.NewGuid() }
            };

            modelBuilder.Entity<Company>().HasData(companies);

            // Çalışanlar
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", Email = "ahmet.yilmaz@arcelik.com", DateOfBirth = new DateTime(1980, 5, 15), HireDate = new DateTime(2010, 3, 1), Role = EmployeeRole.Manager, CompanyId = 1 },
                new Employee { Id = 2, FirstName = "Ayşe", LastName = "Kaya", Email = "ayse.kaya@arcelik.com", DateOfBirth = new DateTime(1985, 8, 22), HireDate = new DateTime(2015, 7, 15), Role = EmployeeRole.Employee, CompanyId = 1 },
                new Employee { Id = 3, FirstName = "Mehmet", LastName = "Demir", Email = "mehmet.demir@turkcell.com.tr", DateOfBirth = new DateTime(1978, 11, 30), HireDate = new DateTime(2008, 9, 1), Role = EmployeeRole.Manager, CompanyId = 2 },
                new Employee { Id = 4, FirstName = "Fatma", LastName = "Şahin", Email = "fatma.sahin@turkcell.com.tr", DateOfBirth = new DateTime(1990, 2, 10), HireDate = new DateTime(2018, 4, 1), Role = EmployeeRole.Employee, CompanyId = 2 },
                new Employee { Id = 5, FirstName = "Ali", LastName = "Öztürk", Email = "ali.ozturk@ulker.com.tr", DateOfBirth = new DateTime(1982, 7, 5), HireDate = new DateTime(2012, 11, 15), Role = EmployeeRole.Manager, CompanyId = 3 },
                new Employee { Id = 6, FirstName = "Zeynep", LastName = "Aksoy", Email = "zeynep.aksoy@flypgs.com", DateOfBirth = new DateTime(1988, 4, 18), HireDate = new DateTime(2016, 6, 1), Role = EmployeeRole.Employee, CompanyId = 4 },
                new Employee { Id = 7, FirstName = "Mustafa", LastName = "Çelik", Email = "mustafa.celik@koc.com.tr", DateOfBirth = new DateTime(1975, 9, 25), HireDate = new DateTime(2005, 2, 1), Role = EmployeeRole.Manager, CompanyId = 5 }
            };

            modelBuilder.Entity<Employee>().HasData(employees);

            // İzin Talepleri
            var leaveRequests = new List<LeaveRequest>
            {
                new LeaveRequest { Id = 1, EmployeeId = 2, StartDate = new DateTime(2023, 7, 1), EndDate = new DateTime(2023, 7, 5), LeaveType = LeaveType.Annual, Status = LeaveRequestStatus.Approved, Reason = "Yıllık izin" },
                new LeaveRequest { Id = 2, EmployeeId = 4, StartDate = new DateTime(2023, 8, 15), EndDate = new DateTime(2023, 8, 17), LeaveType = LeaveType.Sick, Status = LeaveRequestStatus.Approved, Reason = "Sağlık sorunu" },
                new LeaveRequest { Id = 3, EmployeeId = 6, StartDate = new DateTime(2023, 9, 10), EndDate = new DateTime(2023, 9, 14), LeaveType = LeaveType.Annual, Status = LeaveRequestStatus.Pending, Reason = "Aile tatili" }
            };

            modelBuilder.Entity<LeaveRequest>().HasData(leaveRequests);
        }
    }
}