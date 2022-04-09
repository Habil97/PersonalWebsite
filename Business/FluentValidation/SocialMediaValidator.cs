using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class SocialMediaValidator:AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Platform adı boş bırakılamaz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız!");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("En fazla 100 karakter girişi yapınız!");
            RuleFor(x => x.Name).NotEqual("facebook");
            RuleFor(x => x.Name).NotEqual("face");
            RuleFor(x => x.Name).NotEqual("İnstagram");
            RuleFor(x => x.Name).NotEqual("instagram");
            RuleFor(x => x.Name).NotEqual("insta");
            RuleFor(x => x.Name).NotEqual("linkedin");
            RuleFor(x => x.Name).NotEqual("Linkedİn");
            RuleFor(x => x.Name).NotEqual("linkedİn");
            RuleFor(x => x.Name).NotEqual("Linkedin");
            RuleFor(x => x.Name).NotEqual("github");
            RuleFor(x => x.Name).NotEqual("git");
            RuleFor(x => x.Name).NotEqual("youtube");
            RuleFor(x => x.Name).NotEqual("youTube");
            RuleFor(x => x.Name).NotEqual("YouTube");

            RuleFor(x => x.URL).NotEmpty().WithMessage("URL boş bırakılamaz!");

        }
    }
}   
