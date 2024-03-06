using Booking_Backend.Repository.Users.Request;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Users.Validator
{
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator() 
        {
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Email is required!")
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("Invalid email format.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required!");
        }
    }
}
