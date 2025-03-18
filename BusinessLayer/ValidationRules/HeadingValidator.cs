using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Bu alan boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter giriniz.")
                .MaximumLength(50).WithMessage("En fazla 50 karakter giriniz.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Bu alan boş geçilemez.").Must(x=>x>0).WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.WriterId).NotEmpty().WithMessage("Bu alan boş geçilemez.").Must(x => x > 0).WithMessage("Bu alan boş geçilemez");
        }
    }
}
