using cityScope.NET.Server.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Validators
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("{PropertyName} accept only email address")
                .NotEmpty()
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .MaximumLength(255)
                .WithMessage("{PropertyName} maximum length is 255");

            RuleFor(u => u.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .MinimumLength(8)
                .WithMessage("{PropertyName} required min 8 char");

            RuleFor(u => u.ConfirmPassword)
                .NotEmpty()
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .Equal(u => u.Password)
                .WithMessage("{PropertyName} is not equal to Password");
        }
    }
}
