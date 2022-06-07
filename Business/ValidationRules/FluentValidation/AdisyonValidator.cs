using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AdisyonValidator: AbstractValidator<Adisyon>
    {
      
        public AdisyonValidator()
        {
            RuleFor(p => p.AdisyonId).NotEmpty();
        }
    }
}
