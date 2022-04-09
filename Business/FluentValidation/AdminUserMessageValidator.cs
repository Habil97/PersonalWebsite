using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class AdminUserMessageValidator :AbstractValidator<MessageUser>
    {
        public AdminUserMessageValidator()
        {
            RuleFor(x => x.Receiver).NotEmpty().WithMessage("Alıcı maili boş bırakılamaz!");
            RuleFor(x => x.Receiver).EmailAddress();

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş bırakılamaz!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Subject).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");
            
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj içeriği boş bırakılamaz!");
            RuleFor(x => x.MessageContent).MaximumLength(1000).WithMessage("En fazla 1000 karakter girişi yapınız!");

        }
    }
}
