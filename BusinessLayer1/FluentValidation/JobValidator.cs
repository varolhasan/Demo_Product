using EntityLayer1.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer1.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Mesleği boş geçemezsiniz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Meslek en az 3 karakter olmalıdır.");
        }
    }

}
