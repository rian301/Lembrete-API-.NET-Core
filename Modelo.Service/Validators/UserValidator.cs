using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("É necessário digitar o nome.")
                .NotNull().WithMessage("É necessário digitar o nome.");

            RuleFor(c => c.SenhaLogin)
                .NotEmpty().WithMessage("É necessário informar uma senha.")
                .NotNull().WithMessage("É necessário informar uma senha.");
        }
    }
}
