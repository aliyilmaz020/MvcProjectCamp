using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContentValidator : AbstractValidator<Content>
    {
        public ContentValidator()
        {
            RuleFor(x => x.ContentText).NotEmpty().WithMessage("Bu alan boş geçilemez.").MinimumLength(3).WithMessage("En az 3 karakter giriniz.").MaximumLength(1000).WithMessage("En fazla 1000 karakter giriniz");
            RuleFor(x => x.WriterId).NotEmpty().WithMessage("Bu alan boş geçilemez.").Must(x => x > 0).WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.HeadingId).NotEmpty().WithMessage("Bu alan boş geçilemez.").Must(x => x > 0).WithMessage("Bu alan boş geçilemez");
        }
    }
}
