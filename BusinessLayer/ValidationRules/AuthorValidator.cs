using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Lutfen name alanını doldurunuz!");
            RuleFor(x => x.AuthorName).MinimumLength(2).WithMessage("Minimum 2 karekter girişi yapın!");
            RuleFor(W => W.AuthorName).MaximumLength(20).WithMessage("Maximum 20 karekter girişi yapın!");


            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Lutfen e-mail alanını doldurunuz!");
            RuleFor(x => x.AuthorMail).EmailAddress().WithMessage("Lütfen geçerli bir e-mail giriniz.");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Lutfen password alanını doldurunuz!");
            RuleFor(x => x.AuthorPassword).MinimumLength(6).WithMessage("Parolanız en az 6 karakter içermelidir.");
            RuleFor(x => x.AuthorPassword).Must(IsPasswordValid).WithMessage("Parolanızda en az bir küçük harf bir büyük harf ve rakam içermelidir.");


            //RuleFor(W => W.WriterPasswordRepeat).NotEmpty().WithMessage("Şifre Tekrarı Boş Geçilemez!");  
        }

        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
