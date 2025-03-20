using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Lütfen e-posta adresini giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter giriniz.")
                .MinimumLength(10).WithMessage("En az 10 karakter giriniz.");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Lütfen e-posta adresini giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter giriniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen konu başlığını giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter giriniz.")
               .MinimumLength(5).WithMessage("En az 5 karakter giriniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Lütfen mesajınızı giriniz.")
               .MinimumLength(5).WithMessage("En az 5 karakter giriniz.");
        }
    }
}
