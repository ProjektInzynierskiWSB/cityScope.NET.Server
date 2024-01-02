using cityScope.NET.Server.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Validators
{
    public class UpdateAnnouncementValidator : AbstractValidator<UpdateAnnouncementDto>
    {
        public UpdateAnnouncementValidator()
        {
            RuleFor(a => a.Title)
                .MaximumLength(100)
                .WithMessage("{PropertyName} must not exceed between 80 characters");

            RuleFor(a => a.Description)
                .MaximumLength(1000)
                .WithMessage("{PropertyName} must not exceed between 1000 characters");

            RuleFor(a => a.Price)
                .GreaterThan(0)
                .WithMessage("{PropertyName} must be greater than 0")
                .PrecisionScale(10, 2, false)
                .WithMessage("{PropertyName} must not be more than 10 digits in total, with allowance for 2 decimals");
        }
    }
}
