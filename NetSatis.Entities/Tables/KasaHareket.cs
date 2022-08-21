using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.InterFaces;

namespace NetSatis.Entities.Tables
{
    public class KasaHareket : IEntity
    {
        public int Id { get; set; }

        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public string KasaKodu { get; set; }
        public string KasaAdi { get; set; }
        public string OdemeTuruKodu { get; set; }

        public string OdemeTuruAdi { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public DateTime Tarih { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }
    }
}
