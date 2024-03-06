using Booking_Backend.Repository.Users.Request;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Booking_Backend.Repository.Users.Validator
{
    public class RegisterValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.DisplayName).NotEmpty().WithMessage("DisplayName is required!")
                .MaximumLength(100).WithMessage("DisplayName is a more than 100 character!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required!")
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("Invalid email format.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required!")
                .MinimumLength(8).WithMessage("Password is a least 8 characters!")
                .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
                .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
                .Matches("[0-9]").WithMessage("Password must contain at least one numeric digit.")
                .Matches("[!@#$%^&*]").WithMessage("Password must contain at least one special character.");
            RuleFor(x => x.Nation).NotEmpty().WithMessage("Nation in required!");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber in required!")
                .MaximumLength(11).WithMessage("PhoneNumber is a more than 11 character!")
                .MinimumLength(10).WithMessage("PhoneNumber is a least 10 character!")
                .Matches(@"^0\d{9,10}$").WithMessage("PhoneNumber must start by 0 number!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName in required!")
                .MaximumLength(100).WithMessage("UserName is a more than 100 character!");


        }
    }
}
