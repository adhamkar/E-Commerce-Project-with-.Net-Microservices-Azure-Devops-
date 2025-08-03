using E_Commerce.Core.DTOs;
using FluentValidation;

namespace E_Commerce.Core.Validators
{
    public class LoginRequestValidator : AbstractValidator<UserLogin>
    {
        public LoginRequestValidator()
        {
            //Email Validation
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid Email Address Format");
            //Password Validation
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required");
        }
    }
}
