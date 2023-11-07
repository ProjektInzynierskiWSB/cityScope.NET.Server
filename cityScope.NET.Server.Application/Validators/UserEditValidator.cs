using cityScope.NET.Server.Application.Dtos;
using FluentValidation;

namespace cityScope.NET.Server.Application.Validators;

public class UserEditValidator : AbstractValidator<UserDto>
{
	public UserEditValidator()
	{
		RuleFor(u => u.Description)
			.MaximumLength(1000)
            .WithMessage("{PropertyName} maximum length is 1000");
    }
}
