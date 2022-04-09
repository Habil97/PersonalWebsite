using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public  class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Title).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz!");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş bırakılamaz!");
            RuleFor(x => x.Mail).EmailAddress();

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon numarası boş bırakılamaz!");

        }
    }
}
