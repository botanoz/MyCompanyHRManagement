using AutoMapper;
using MyCompanyHRManagement.Application.DTOs;
using MyCompanyHRManagement.Application.Interfaces;
using MyCompanyHRManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCompanyHRManagement.Application.Services
{
    public class LeaveRequestService : ILeaveRequestService
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public LeaveRequestService(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LeaveRequestDto>> GetAllLeaveRequestsAsync()
        {
            var leaveRequests = await _leaveRequestRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<LeaveRequestDto>>(leaveRequests);
        }

        public async Task<LeaveRequestDto> GetLeaveRequestByIdAsync(int id)
        {
            var leaveRequest = await _leaveRequestRepository.GetByIdAsync(id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }

        public async Task<LeaveRequestDto> CreateLeaveRequestAsync(LeaveRequestDto leaveRequestDto)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(leaveRequestDto);
            await _leaveRequestRepository.AddAsync(leaveRequest);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }

        public async Task<LeaveRequestDto> UpdateLeaveRequestAsync(LeaveRequestDto leaveRequestDto)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(leaveRequestDto);
            await _leaveRequestRepository.UpdateAsync(leaveRequest);
            return leaveRequestDto;
        }

        public async Task DeleteLeaveRequestAsync(int id)
        {
            var leaveRequest = await _leaveRequestRepository.GetByIdAsync(id);
            if (leaveRequest != null)
            {
                await _leaveRequestRepository.DeleteAsync(leaveRequest);
            }
        }

        public async Task<LeaveRequestDto> ApproveLeaveRequestAsync(int id)
        {
            var leaveRequest = await _leaveRequestRepository.GetByIdAsync(id);
            if (leaveRequest != null)
            {
                leaveRequest.Status = Domain.Enums.LeaveRequestStatus.Approved;
                await _leaveRequestRepository.UpdateAsync(leaveRequest);
            }
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }

        public async Task<LeaveRequestDto> RejectLeaveRequestAsync(int id)
        {
            var leaveRequest = await _leaveRequestRepository.GetByIdAsync(id);
            if (leaveRequest != null)
            {
                leaveRequest.Status = Domain.Enums.LeaveRequestStatus.Rejected;
                await _leaveRequestRepository.UpdateAsync(leaveRequest);
            }
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}