using HR.LeaveManagement.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTO.LeaveRequest
{
    public class LeaveRequestListDto: BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public bool? Approved { get; set; }
        public DateTime DateRequested { get; set; }
    }
}
