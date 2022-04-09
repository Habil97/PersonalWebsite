using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Okul adı boş bırakılamaz!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Title).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih boş bırakılamaz!");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En az 50 karakter girişi yapınız!");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("En fazla 500 karakter girişi yapınız!");

        }
    }
}
