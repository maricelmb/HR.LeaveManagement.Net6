﻿using HR.LeaveManagement.Application.DTOs.LeaveAllocation;

namespace HR.LeaveManagement.Application.DTO.LeaveAllocation
{
    public class CreateLeaveAllocationDto : ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }

        public int Period { get; set; }
    }
}
