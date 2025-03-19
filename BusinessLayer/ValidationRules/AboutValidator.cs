using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutDetails1).NotEmpty().WithMessage("Bu alan boş geçilemez.").MinimumLength(10).WithMessage("En az 10 karakter giriniz.").MaximumLength(1000).WithMessage("En fazla 1000 karakter giriniz");
            RuleFor(x => x.AboutDetails2).NotEmpty().WithMessage("Bu alan boş geçilemez.").MinimumLength(10).WithMessage("En az 10 karakter giriniz.").MaximumLength(1000).WithMessage("En fazla 1000 karakter giriniz");
            RuleFor(x => x.AboutImage1).NotEmpty().WithMessage("Bu alan boş geçilemez.").MinimumLength(10).WithMessage("En az 10 karakter giriniz.").MaximumLength(200).WithMessage("En fazla 200 karakter giriniz");
            RuleFor(x => x.AboutImage2).NotEmpty().WithMessage("Bu alan boş geçilemez.").MinimumLength(10).WithMessage("En az 10 karakter giriniz.").MaximumLength(200).WithMessage("En fazla 200 karakter giriniz");
        }
    }
}
