using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Bu alan boş geçilemez.").MaximumLength(20).WithMessage("En fazla 20 karakter giriniz.").MinimumLength(2).WithMessage("En az 2 karakter giriniz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Bu alan boş geçilemez.").MaximumLength(20).WithMessage("En fazla 20 karakter giriniz.").MinimumLength(2).WithMessage("En az 2 karakter giriniz.");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Bu alan boş geçilemez.").MaximumLength(300).WithMessage("En fazla 300 karakter giriniz.").MinimumLength(5)
                .WithMessage("En az 10 karakter giriniz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Bu alan boş geçilemez.").MaximumLength(100).WithMessage("En fazla 100 karakter giriniz.").MinimumLength(10)
                .WithMessage("En az 10 karakter giriniz.").EmailAddress().WithMessage("E-Postanızı doğru biçimde giriniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(20).WithMessage("En fazla 20 karakter giriniz.").MinimumLength(5).WithMessage("En az 5 karakter giriniz.")
                .Matches("[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir.")
                .Matches("[a-z]").WithMessage("Şifre en az bir küçük harf içermelidir.")
                .Matches(@"\d").WithMessage("Şifre en az bir rakam içermelidir.")
                .Matches(@"[\W_]").WithMessage("Şifre en az bir özel karakter içermelidir.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(100).WithMessage("En fazla 100 karakter giriniz.").MinimumLength(5).WithMessage("En az 5 karakter giriniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Bu alan boş geçilemez").MaximumLength(30).WithMessage("En fazla 30 karakter giriniz.").MinimumLength(5).WithMessage("En az 5 karakter giriniz.");
        }
    }
}
