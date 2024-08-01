using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}