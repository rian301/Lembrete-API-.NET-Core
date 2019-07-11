using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
   public class LembreteValidator : AbstractValidator<Lembrete>
    {
        public LembreteValidator()
        {
            RuleFor(c => c.Texto)
               .NotEmpty().WithMessage("É necessário digitar um texto.")
               .NotNull().WithMessage("É necessário digitar um texto.");
            
        }
    }
}
