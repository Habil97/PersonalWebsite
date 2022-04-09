using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
   public class AnnouncementValidator :AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Title).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş bırakılamaz!");
            RuleFor(x => x.Content).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Content).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Tarih).NotEmpty().WithMessage("Tarih boş bırakılamaz!");

        }
    }
}
