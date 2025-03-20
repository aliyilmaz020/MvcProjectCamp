using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(30).WithMessage("En fazla 30 karakter girişi yapınız.").MinimumLength(5).WithMessage("En az 5 karakter girişi yapınız.");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(100).WithMessage("En fazla 100 karakter girişi yapınız.").MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(100).WithMessage("En fazla 100 karakter girişi yapınız.").MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(1000).WithMessage("En fazla 1000 karakter girişi yapınız.").MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız.");
        }
    }
}
