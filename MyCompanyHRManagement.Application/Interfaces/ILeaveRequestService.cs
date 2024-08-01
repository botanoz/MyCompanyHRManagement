using MyCompanyHRManagement.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Interfaces
{
    public interface ILeaveRequestService
    {
        Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequestsAsync();
        Task<LeaveRequestDto> GetLeaveRequestByIdAsync(int id);
        Task<LeaveRequestDto> CreateLeaveRequestAsync(LeaveRequestDto leaveRequestDto);
        Task<LeaveRequestDto> UpdateLeaveRequestAsync(LeaveRequestDto leaveRequestDto);
        Task DeleteLeaveRequestAsync(int id);
        Task<LeaveRequestDto> ApproveLeaveRequestAsync(int id);
        Task<LeaveRequestDto> RejectLeaveRequestAsync(int id);
    }
}