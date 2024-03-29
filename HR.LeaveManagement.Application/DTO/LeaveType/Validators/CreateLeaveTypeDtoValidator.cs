﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTO.LeaveType.Validators
{
    internal class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        internal CreateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());
        }
    }
}
