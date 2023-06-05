using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklma kısmı boş geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("lütfen görsel seçiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("lütfen en az 50 karakterli görsel seçiniz");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("lütfen açıklamayı kısaltın");

        }
    }
}
