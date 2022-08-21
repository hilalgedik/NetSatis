using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari kodu alanı boş geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari adı boş geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kisi boş geçilemez.");

            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Unvani adı boş geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz email adresi geçersizdir.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto oranı sıfırdan küçük olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk limiti sıfırdan küçük olamaz.");





        }
    }
}
