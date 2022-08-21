using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class OdemeTuruValidator:AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Odeme türü Kodu alanı boş geçilemez");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Odeme türü adı alanı boş geçilemez");
        }
    }
}
