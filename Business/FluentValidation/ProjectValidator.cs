using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.PlatformImage).NotEmpty().WithMessage("Platform görseli boş bırakılamaz!");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform adı boş bırakılamaz!");
            RuleFor(x => x.Platform).MinimumLength(3).WithMessage("En az 3 karakter giriniz!");
            RuleFor(x => x.Platform).MaximumLength(250).WithMessage("En fazla 250 karakter giriniz!");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş bırakılamaz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter giriniz!");
            RuleFor(x => x.Name).MaximumLength(250).WithMessage("En fazla 250 karakter giriniz!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Lütfen bir fiyat giriniz!");

            RuleFor(x => x.CompletionTime).NotEmpty().WithMessage("0-100 arası bir değer giriniz!");

            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Proje küçük görsel boş bırakılamaz!");

            RuleFor(x => x.ImageURL2).NotEmpty().WithMessage("Proje büyük görsel boş bırakılamaz!");

            RuleFor(x => x.URL).NotEmpty().WithMessage("Proje URL'si boş bırakılamaz!");
        }
    }
}
