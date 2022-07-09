using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTO.LeaveType.Validators
{
    internal class UpdateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        internal UpdateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} is required.")
        }
       
    }
}
