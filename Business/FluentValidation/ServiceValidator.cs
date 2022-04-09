using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class ServiceValidator :AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Title).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

        }
    }
}
