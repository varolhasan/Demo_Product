using EntityLayer1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer1.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri ismi boş geçilemez!");
        }
    }
}
