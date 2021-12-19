using FluentValidation;
using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {                 

            RuleFor(x => x.FirstName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Please do not leave your name blank!!");
            RuleFor(x => x.FirstName)
                .MaximumLength(30)
                .Length(3, 30)
                .WithMessage("Please do not enter your name more than 30 characters......");

            RuleFor(x => x.LastName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Please do not leave your surname blank!");
            RuleFor(x => x.LastName)
                .MaximumLength(20)
                .Length(3, 30)
                .WithMessage("Please do not enter your name surname than 20 characters......");

            RuleFor(x => x.Company)
               .NotNull()
               .NotEmpty()
               .WithMessage("Please do not leave your Company blank!!");
            RuleFor(x => x.Company)
                .MaximumLength(30)
                .Length(3, 30)
                .WithMessage("Please do not enter your name more than 30 characters......");

        }
       
    }
}
