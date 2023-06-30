using cityScope.NET.Server.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Validators
{
    public class UserLoginValidator : AbstractValidator<UserLoginDto>
    {
        public UserLoginValidator()
        {
            RuleFor(u => u.Email)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("{PropertyName} is required")
                 .EmailAddress()
                 .WithMessage("{PropertyName} accept only email address")
                 .MaximumLength(255)
                 .WithMessage("{PropertyName} maximum length is 255");

            RuleFor(u => u.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required");
        }
    }
}
