using AutoMapper;
using HR.LeaveManagement.Application.DTO;
using HR.LeaveManagement.Application.Features.LeaveTypes.Request;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly IMapper _mapper;   
        private readonly ILeaveTypeRepository _leaveTypeRepository; 
        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)        
        {
            _mapper = mapper;   
            _leaveTypeRepository = leaveTypeRepository; 
        }

        async Task<LeaveTypeDto> IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>.Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
