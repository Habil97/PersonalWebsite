using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class TestimonialValidator:AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Görsel boş bırakılamaz!");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad-Soyad boş bırakılamaz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("En fazla 100 karakter girişi yapınız!");

            RuleFor(x => x.Appellation).NotEmpty().WithMessage("Unvan boş bırakılamaz!");
            RuleFor(x => x.Appellation).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Appellation).MaximumLength(250).WithMessage("En fazla 250 karakter girişi yapınız!");

            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum  boş bırakılamaz!");
            RuleFor(x => x.Comment).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Comment).MaximumLength(1000).WithMessage("En fazla 1000 karakter girişi yapınız!");
        }
    }
}
