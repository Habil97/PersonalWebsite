using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class InformationValidator : AbstractValidator<Information>
    {
        public InformationValidator()
        {
            RuleFor(x => x.Header).NotEmpty().WithMessage("Üst başlık boş bırakılamaz!");
            RuleFor(x => x.Header).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Header).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Alt başlık boş bırakılamaz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Name).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Appellation).NotEmpty().WithMessage("Unvan boş bırakılamaz!");
            RuleFor(x => x.Appellation).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Appellation).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");
        }
    }
}
