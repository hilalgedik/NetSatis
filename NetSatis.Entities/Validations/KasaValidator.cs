using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu alanı boş geçilemez");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa adı alanı boş geçilemez");
        }
    }
}
