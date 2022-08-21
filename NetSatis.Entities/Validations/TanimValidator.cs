using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım türü alanı boş geçilemez");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
