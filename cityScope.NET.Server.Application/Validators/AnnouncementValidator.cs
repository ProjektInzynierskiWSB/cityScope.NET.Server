using cityScope.NET.Server.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Validators
{
    public class AnnouncementValidator : AbstractValidator<AddAnnouncementDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(a => a.Title)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(100)
                .WithMessage("{PropertyName} must not exceed between 80 characters");

            RuleFor(a => a.Description)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(1000)
                .WithMessage("{PropertyName} must not exceed between 1000 characters");

            RuleFor(a => a.Price)
                .GreaterThan(0)
                .WithMessage("{PropertyName} must be greater than 0")
                .NotNull()
                .PrecisionScale(10, 2, false)
                .WithMessage("{PropertyName} must not be more than 10 digits in total, with allowance for 2 decimals");
        }
    }
}
