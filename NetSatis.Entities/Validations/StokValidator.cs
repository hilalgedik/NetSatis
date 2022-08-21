using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok kodu boş geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok adı boş geçilemez.").Length(5,50).
                WithMessage("Stok adı alanı 5 ile 50 karakter arasında olabilir.");
            RuleFor(p=>p.Barkod).NotEmpty().WithMessage("Barkod boş geçilemez.");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alis fiyatı1 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alis fiyatı2 alanı 0'a eşit veya büyük olmalıdır.");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alis fiyatı3 alanı 0'a eşit veya büyük olmalıdır.");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı1 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı2 alanı 0'a eşit veya büyük olmalıdır.");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı3 alanı 0'a eşit veya büyük olmalıdır.");






        }
    }
}
