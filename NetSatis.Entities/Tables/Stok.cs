﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.InterFaces;

namespace NetSatis.Entities.Tables
{
    public class Stok : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Barkod { get; set; }
        public string BarkodTuru { get; set; }
        public string Birimi { get; set; }
        public string StokGrubu { get; set; }
        public string StokAltGrubu { get; set; }
        public string Marka { get; set; }
        public string Modeli { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }

        public string GarantiSuresi { get; set; }
        public string UreticiKodu { get; set; }
        public int AlisKdv { get; set; }
        public int SatisKdv { get; set; }
        public Nullable<decimal> AlisFiyati1 { get; set; }
        public Nullable<decimal> AlisFiyati2 { get; set; }
        public Nullable<decimal> AlisFiyati3 { get; set; }
        public Nullable<decimal> SatisFiyati1 { get; set; }
        public Nullable<decimal> SatisFiyati2 { get; set; }
        public Nullable<decimal> SatisFiyati3 { get; set; }

        public Nullable<decimal> MinStokMiktari { get; set; }
        public Nullable<decimal> MaxStokMiktari { get; set; }
        public string Aciklama { get; set; }



    }
}
