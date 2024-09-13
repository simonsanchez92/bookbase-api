﻿using Bookbase.Application.Dtos.Requests;
using FluentValidation;

namespace Bookbase.Validators
{
    public class LoginValidator : AbstractValidator<LoginRequestDto>
    {

        public LoginValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required");
        }
    }
}
