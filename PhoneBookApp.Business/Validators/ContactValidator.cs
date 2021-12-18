using FluentValidation;
using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Please do not leave your E-mail blank!!")
                .When(x => !string.IsNullOrEmpty(x.Email));
            RuleFor(x => x.Email)
                .MaximumLength(50)
                .Length(3, 30)
                .WithMessage("Please do not enter your E-mail more than 50 characters......");

            RuleFor(x => x.PhoneNumber)
                .NotNull()
                .NotEmpty()
                .WithMessage("Please do not leave your Phone Number blank!!");                
            RuleFor(x => x.PhoneNumber)
                .MaximumLength(100)                
                .WithMessage("Please do not enter your Phone Number more than 10 characters and less then 10......");

            RuleFor(x => x.Address)
                .NotNull()
                .NotEmpty()
                .WithMessage("Please do not leave your Address blank!!");                
            RuleFor(x => x.Address)
                .MaximumLength(50)
                .Length(3, 60)
                .WithMessage("Please do not enter your Address more than 60 characters......");

            RuleFor(x => x.City)
               .NotNull()
               .NotEmpty()
               .WithMessage("Please do not leave your City blank!!");               
            RuleFor(x => x.Address)
                .MaximumLength(20)
                .Length(3, 20)
                .WithMessage("Please do not enter your City more than 20 characters......");

            RuleFor(x => x.Address)
               .NotNull()
               .NotEmpty()
               .WithMessage("Please do not leave your Address blank!!");           
            RuleFor(x => x.Address)
                .MaximumLength(50)
                .Length(3, 60)
                .WithMessage("Please do not enter your Address more than 60 characters......");

            RuleFor(x => x.District)
               .NotNull()
               .NotEmpty()
               .WithMessage("Please do not leave your District blank!!");               
            RuleFor(x => x.Address)
                .MaximumLength(50)
                .Length(3, 60)
                .WithMessage("Please do not enter your District more than 60 characters......");
        }
    }
}
