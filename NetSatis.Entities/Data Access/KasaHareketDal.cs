using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.Data_Access
{
    public class KasaHareketDal : EntityRepositoryBase<NetSatisContext, KasaHareket,KasaHareketValidator>
    {
    }
}
