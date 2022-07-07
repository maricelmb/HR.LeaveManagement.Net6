﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTO.LeaveAllocation
{
    public class CreateLeaveAllocationDto:BaseDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }

        public int Period { get; set; }
    }
}
