using E_Commerce.Core.DTOs;
using E_Commerce.Core.Entities;
using FluentValidation;

namespace E_Commerce.Core.Validators
{
    public class RegisterRequestValidator : AbstractValidator<UserRegisterRequest>
    {
        public RegisterRequestValidator()
        {
            //Email Validation
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid Email Address Format");
            //Password Validation
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password length must contains at least 8 characters")
                .Matches("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{2,})$")
                .WithMessage("Password can only contain alphanumeric characters");
            
            RuleFor(x => x.PersonName)
                .NotEmpty().WithMessage("PersonName is required")
                .Length(1,50).WithMessage("Length is between 1 and 50 characters");
            RuleFor(x => x.Gender)
                .IsInEnum().WithMessage("Gender must be a valid enum value.");
        }
    }
}
